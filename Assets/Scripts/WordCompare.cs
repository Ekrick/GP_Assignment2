using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordCompare : MonoBehaviour
{
    private static WordCompare _instance;
    public static WordCompare Instance { get { return _instance; } }

    List<int> _greenIndexList = new List<int>();
    List<int> _yellowIndexList = new List<int>();
    List<char> _triedLetters = new List<char>();
    private bool _haveWon = false;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private List<char> StringToCharList(string word)
    {
        List<char> list = new List<char>();
        list.AddRange(word);
        return list;
    }
    private void FirstCompare(List<char> guess, List<char> target)
    {
        int count = 0;
        for (int i = 0; i < target.Count; i++)
        {
            if (target[i] == guess[i])
            {
                Debug.Log("Rätt: " + i);
                _triedLetters.Add(target[i]);
                _greenIndexList.Add(i);
                target[i] = '+';
                guess[i] = '-';
                count++; ;
            }
        }
        if (count == 5)
        {
            _haveWon = true;
        }
    }
    private void SecondCompare(List<char> guess, List<char> target)
    {
        foreach (char c in target)
        {
            SmallCompare(guess, c);
        }
    }
    private void SmallCompare(List<char> guess, char target)
    {
        for (int i = 0; i < guess.Count; i++)
        {
            if (target == guess[i])
            {
                guess[i] = '_';
                _yellowIndexList.Add(i);
                Debug.Log("Nästan rätt: " + i);
                break;
            }
        }
    }

    //private void SmallCompare(char guess, List<char> target)
    //{
    //    for (int i = 0; i < target.Count; i++)
    //    {
    //        if (guess == target[i])
    //        {
    //            target[i] = '+';
    //            Debug.Log("Nästan rätt: " + guess);
    //            break;
    //        }
    //    }
    //}


    public void Compare(string guess, string target)
    {
        List<char> guessList = StringToCharList(guess);
        List<char> targetList = StringToCharList(target);
        _greenIndexList.Clear();
        _yellowIndexList.Clear();
        FirstCompare(guessList, targetList);
        if (_haveWon)
        {
            Debug.Log("You Win");
        }
        else
        {
            SecondCompare(guessList, targetList);
            Debug.Log("You Lose");
        }
    }

    public List<int> GetGreens()
    {
        return _greenIndexList;
    }
    public List<int> GetYellows()
    {
        return _yellowIndexList;
    }
    public bool CheckWin()
    {
        return _haveWon;
    }

}
