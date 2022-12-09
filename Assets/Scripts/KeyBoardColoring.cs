using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoardColoring : MonoBehaviour
{
    [SerializeField] private WordCompare _wordCompare;
    List<GameObject> _keyList = new List<GameObject>();


    private void Start()
    {
        AddChildren(this.gameObject);
    }

    private char TextCheck(GameObject obj)
    {
        char c = char.Parse(obj.GetComponentInChildren<TextMeshProUGUI>().text);
        return c;
    }
    private List<GameObject> ColorList(HashSet<char> colorSet)
    {
        List<GameObject> outList = new List<GameObject>();
        foreach (GameObject key in _keyList)
        {
            if (colorSet.Contains(TextCheck(key)))
            {
                outList.Add(key);
            }
        }
        return outList;
    }

    public List<GameObject> GreenList()
    {
        return ColorList(_wordCompare.GetGreenLetters());
    }
    public List<GameObject> YellowList()
    {
        return ColorList(_wordCompare.GetYellowLetters());
    }
    public List<GameObject> GreyList()
    {
        return ColorList(_wordCompare.GetGreyLetters());
    }

    private void AddChildren(GameObject obj)
    {
        foreach (Transform child in obj.transform)
        {
            _keyList.Add(child.gameObject);
        }

    }
}
