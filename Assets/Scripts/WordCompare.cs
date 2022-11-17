using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordCompare : MonoBehaviour
{
    [SerializeField] private string _targetTest = "testa";
    [SerializeField] private string _guessTest = "testa";
    List<char> _targetList = new List<char>();
    List<char> _guessList = new List<char>();

    private void Start()
    {
        _targetList = StringToCharList(_targetTest);
        _guessList = StringToCharList(_guessTest);
        foreach (char c in _targetList)
        {
            Debug.Log(c);
        }
        foreach (char c in _guessList)
        {
            Debug.Log(c);
        }
    }

    private List<char> StringToCharList(string word)
    {
        List<char> list = new List<char>();
        list.AddRange(word);
        return list;
    }

    public void BigCompare(string target, string guess)
    {
        List<int> indexList = MatchingIndexList(target, guess);
        string t = target;
        string g = guess;
        int count = 0;
        foreach (int i in indexList)
        {
            int indx = i - count;
            t = t.Remove(indx, 1);
            g = g.Remove(indx, 1);
            count++;
        }
        foreach (char c in t)
        {
            SmallCompare(c, g);
        }


    }

    private List<int> MatchingIndexList(string target, string guess)
    {
        List<int> indexList = new List<int>();
        for (int i = 0; i < target.Length; i++)
        {
            if (target[i] == guess[i])
            {
                Debug.Log("Rätt" + guess[i]);
                indexList.Add(i);
            }
        }
        return indexList;
    }



    private void SmallCompare(char target, string guess)
    {
        bool temp = false;
        for (int i = 0; i < guess.Length; i++)
        {
            if (target == guess[i])
            {
                Debug.Log("Nästan rätt" + target);
                break;
            }
        }
    }

}
