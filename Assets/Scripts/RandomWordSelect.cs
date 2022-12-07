using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

public class RandomWordSelect : MonoBehaviour
{
    [SerializeField] private TextAsset _wordFile;
    [SerializeField] private string[] _wordArray;

    private void Awake()
    {
        _wordFile = Resources.Load("FiveLetterWords") as TextAsset;
        _wordArray = _wordFile.text.Split('\n');
        CleanUpWords(_wordArray);
    }

    private void CleanUpWords(string[] array)
    {

        foreach (string word in array)
        {
            string cleaned = word.Trim('\n', '\r', '\t');
            int index = Array.IndexOf(array, word);
            array[index] = cleaned;
        }
    }

    public string RandomWord() => _wordArray[UnityEngine.Random.Range(0, _wordArray.Length - 1)];
}
