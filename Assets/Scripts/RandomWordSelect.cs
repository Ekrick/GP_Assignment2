using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomWordSelect : MonoBehaviour
{
    [SerializeField] private TextAsset _wordFile;
    [SerializeField] private string[] _wordArray;

    private void Awake()
    {
        _wordFile = Resources.Load("FiveLetterWords") as TextAsset;
        _wordArray = _wordFile.text.Split('\n');

    }

    public string RandomWord() => _wordArray[Random.Range(0, _wordArray.Length - 1)];

}
