using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    [Header ("Scripts")]
    [SerializeField] private TextBoxScript _boxScript1;
    [SerializeField] private TextBoxScript _boxScript2;
    [SerializeField] private TextBoxScript _boxScript3;
    [SerializeField] private TextBoxScript _boxScript4;
    [SerializeField] private TextBoxScript _boxScript5;

    [Header("Other")]
    [SerializeField] private int _rowIndex;
    List<TextBoxScript> _rowList = new List<TextBoxScript>();

    private string _currentGuess = "";


    private void Start()
    {
        _rowList.Add(_boxScript1);
        _rowList.Add(_boxScript2);
        _rowList.Add(_boxScript3);
        _rowList.Add(_boxScript4);
        _rowList.Add(_boxScript5);

    }

    public void AddToString(char c)
    {
        if (_currentGuess.Length < 5)
        {
            _currentGuess += c;
        }
        _rowList[_rowIndex].AddText(char.ToUpper(c));
        Debug.Log(_currentGuess);
    }
    public void RemoveFromString()
    {
        if (_currentGuess.Length > 0)
        {
            _currentGuess = _currentGuess.Remove(_currentGuess.Length - 1, 1);
        }
        _rowList[_rowIndex].RemoveText();
        Debug.Log(_currentGuess);
    }

    public void EnterPressed()
    {
        if (_rowIndex < _rowList.Count -1 && _rowList[_rowIndex].CheckFull())
        {
            _rowIndex++;
            _currentGuess = "";
        }
    }
}
