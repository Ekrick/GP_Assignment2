using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoardColoring : MonoBehaviour
{
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
        return ColorList(WordCompare.Instance.GetGreenLetters());
    }
    public List<GameObject> YellowList()
    {
        return ColorList(WordCompare.Instance.GetYellowLetters());
    }
    public List<GameObject> GreyList()
    {
        return ColorList(WordCompare.Instance.GetGreyLetters());
    }

    private void AddChildren(GameObject obj)
    {
        foreach (Transform child in obj.transform)
        {
            _keyList.Add(child.gameObject);
        }

    }
}
