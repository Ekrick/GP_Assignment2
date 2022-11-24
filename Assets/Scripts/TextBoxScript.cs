using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBoxScript : MonoBehaviour
{
    [Header("Text Boxes")]
    [SerializeField] private GameObject _textBox1;
    [SerializeField] private GameObject _textBox2;
    [SerializeField] private GameObject _textBox3;
    [SerializeField] private GameObject _textBox4;
    [SerializeField] private GameObject _textBox5;


    [Header ("Other")]
    [SerializeField] private string empty = "";
    [SerializeField] private int _boxIndex;

    List<GameObject> _boxList = new List<GameObject>();

    private void Start()
    {
        _boxList.Add(_textBox1);
        _boxList.Add(_textBox2);
        _boxList.Add(_textBox3);
        _boxList.Add(_textBox4);
        _boxList.Add(_textBox5);
    }


    public void AddText(char c)
    {

        if (_boxIndex < _boxList.Count)
        {
            TextMeshProUGUI boxtext = _boxList[_boxIndex].GetComponentInChildren<TextMeshProUGUI>();
            boxtext.text = "" + c;
            _boxIndex++;
        }
    }
    public void RemoveText()
    {

        if (_boxIndex > 0)
        {
            _boxIndex--;
            TextMeshProUGUI boxtext = _boxList[_boxIndex].GetComponentInChildren<TextMeshProUGUI>();
            boxtext.text = empty;

        }
    }
    public bool CheckFull()
    {
        return _boxIndex >= _boxList.Count;
    }
}
