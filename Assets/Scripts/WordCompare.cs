using System.Collections.Generic;
using UnityEngine;

public class WordCompare : MonoBehaviour
{
    private static WordCompare _instance;
    public static WordCompare Instance { get { return _instance; } }

    //Box Coloring
    List<int> _greenIndexList = new List<int>();
    List<int> _yellowIndexList = new List<int>();

    //Keyboard Coloring
    HashSet<char> _greenLetters = new HashSet<char>();
    HashSet<char> _yellowLetters = new HashSet<char>();
    HashSet<char> _greyLetters = new HashSet<char>();

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
        foreach (char c in word)
        {
            list.Add(char.ToUpper(c));
        }
        return list;
    }
    private void FirstCompare(List<char> guess, List<char> target)
    {
        int count = 0;
        for (int i = 0; i < target.Count; i++)
        {
            if (target[i] == guess[i])
            {
                _greenLetters.Add(guess[i]);
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
                _yellowLetters.Add(guess[i]);
                _yellowIndexList.Add(i);
                guess[i] = '_';
                break;
            }
        }
    }

    public void Compare(string guess, string target)
    {
        List<char> guessList = StringToCharList(guess);
        List<char> targetList = StringToCharList(target);
        _greenIndexList.Clear();
        _yellowIndexList.Clear();

        foreach (char c in guessList)
        {
            _greyLetters.Add(c);
        }

        FirstCompare(guessList, targetList);
        if (!_haveWon)
        {
            SecondCompare(guessList, targetList);
        }
    }

    public List<int> GetGreenIndex()
    {
        return _greenIndexList;
    }
    public List<int> GetYellowIndex()
    {
        return _yellowIndexList;
    }
    public HashSet<char> GetGreenLetters()
    {
        return _greenLetters;
    }
    public HashSet<char> GetYellowLetters()
    {
        return _yellowLetters;
    }
    public HashSet<char> GetGreyLetters()
    {
        return _greyLetters;
    }

    public bool CheckWin()
    {
        return _haveWon;
    }

}
