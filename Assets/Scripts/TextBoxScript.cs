using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBoxScript : MonoBehaviour
{
    [Header("Text Boxes")]
    [SerializeField] private GameObject _textBox1;
    [SerializeField] private GameObject _textBox2;
    [SerializeField] private GameObject _textBox3;
    [SerializeField] private GameObject _textBox4;
    [SerializeField] private GameObject _textBox5;

    List<GameObject> _boxList = new List<GameObject>();
    private int _boxIndex;

    private void Start()
    {
        _boxList.Add(_textBox1);
        _boxList.Add(_textBox2);
        _boxList.Add(_textBox3);
        _boxList.Add(_textBox4);
        _boxList.Add(_textBox5);
    }

    private void ColorChanger(GameObject obj, Color color)
    {
        obj.GetComponent<Image>().color = color;
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
            boxtext.text = "";

        }
    }
    public void ColorBoxes(List<int> greenList, List<int> yellowList)
    {
        int currentIndex = 0;
        foreach (GameObject box in _boxList)
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
    public bool CheckFull()
    {
        return _boxIndex >= _boxList.Count;
    }
}
