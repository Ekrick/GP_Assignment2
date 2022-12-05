using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour
{
    [Header ("Rows")]
    [SerializeField] private TextBoxScript _boxScript1;
    [SerializeField] private TextBoxScript _boxScript2;
    [SerializeField] private TextBoxScript _boxScript3;
    [SerializeField] private TextBoxScript _boxScript4;
    [SerializeField] private TextBoxScript _boxScript5;

    [Header("Scripts")]
    [SerializeField] private KeyBoardColoring _keyBoardColoring;
    [SerializeField] private RandomWordSelect _randomWordSelect;

    [Header ("Other")]
    [SerializeField] private string _targetWord;
    [SerializeField] private int _rowIndex;
    List<TextBoxScript> _rowList = new List<TextBoxScript>();
    private string _currentGuess = string.Empty;


    private void Start()
    {
        _targetWord = _randomWordSelect.RandomWord();
        EndMessage._correctWord = _targetWord;
        _rowList.Add(_boxScript1);
        _rowList.Add(_boxScript2);
        _rowList.Add(_boxScript3);
        _rowList.Add(_boxScript4);
        _rowList.Add(_boxScript5);

    }
    private void ColorChanger(GameObject obj, Color color)
    {
        obj.GetComponent<Image>().color = color;
    }
    private void ColorBoxes(List<GameObject> boxes, List<int> greenList, List<int> yellowList)
    {
        int currentIndex = 0;
        foreach (GameObject box in boxes)
        {
            if (greenList.Contains(currentIndex))
            {
                ColorChanger(box, Color.green);
            }
            else if (yellowList.Contains(currentIndex))
            {
                ColorChanger(box, Color.yellow);
            }
            else
            {
                ColorChanger(box, Color.grey);
            }
            currentIndex++;
        }
    }
    private void ColorKeys(List<GameObject> green, List<GameObject> yellow, List<GameObject> grey)
    {
        foreach (GameObject key in grey)
        {
            ColorChanger(key, Color.grey);
        }
        foreach (GameObject key in yellow)
        {
            ColorChanger(key, Color.yellow);
        }
        foreach (GameObject key in green)
        {
            ColorChanger(key, Color.green);
        }
    }
    private void EnterModeSelect()
    {
        if (WordCompare.Instance.CheckWin())
        {
            EndMessage._didWin = true;
            SceneManager.LoadScene(1);
        }
        else if (_rowIndex < _rowList.Count - 1)
        {
            _rowIndex++;
            _currentGuess = "";
        }
        else
        {
            EndMessage._didWin = false;
            SceneManager.LoadScene(1);
        }
    }



    public void AddToString(char c)
    {
        if (_currentGuess.Length < 5)
        {
            _currentGuess += c;
        }
        _rowList[_rowIndex].AddText(c);
    }
    public void RemoveFromString()
    {
        if (_currentGuess.Length > 0)
        {
            _currentGuess = _currentGuess.Remove(_currentGuess.Length - 1, 1);
        }
        _rowList[_rowIndex].RemoveText();
    }

    public void EnterPressed()
    {
        if (_rowList[_rowIndex].CheckFull())
        {
            WordCompare.Instance.Compare(_currentGuess, _targetWord);
            ColorBoxes(_rowList[_rowIndex].GetBoxList(), WordCompare.Instance.GetGreenIndex(), WordCompare.Instance.GetYellowIndex());
            ColorKeys(_keyBoardColoring.GreenList(), _keyBoardColoring.YellowList(), _keyBoardColoring.GreyList());
            EnterModeSelect();
        }
    }
}
