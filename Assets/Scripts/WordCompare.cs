using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordCompare : MonoBehaviour
{
    [SerializeField] private string _targetTest = "testa";
    [SerializeField] private string _guessTest = "testa";
    List<char> _triedLetters = new List<char>();
    List<char> _targetList = new List<char>();
    List<char> _guessList = new List<char>();

    private void Start()
    {
        _targetList = StringToCharList(_targetTest);
        _guessList = StringToCharList(_guessTest);
        Compare(_guessList, _targetList);
    }


    //private char[] StringToCharArray(string word)
    //{
    //    char[] array = new char[5];
    //    for (int i = 0; i < word.Length; i++)
    //    {
    //        array[i] = word[i];
    //    }
    //    return array;
    //}
    private List<char> StringToCharList(string word)
    {
        List<char> list = new List<char>();
        list.AddRange(word);
        return list;
    }
    private void FirstCompare(List<char> guess, List<char> target)
    {
        for (int i = 0; i < target.Count; i++)
        {
            if (target[i] == guess[i])
            {
                Debug.Log("Rätt: " + guess[i]);
                _triedLetters.Add(target[i]);
                target[i] = '+';
                guess[i] = '-';
            }
        }
    }
    private void SecondCompare(List<char> guess, List<char> target)
    {
        foreach (char c in guess)
        {
            SmallCompare(c, target);
        }
    }
    private void SmallCompare(char guess, List<char> target)
    {
        for (int i = 0; i < target.Count; i++)
        {
            if (guess == target[i])
            {
                target[i] = '+';
                Debug.Log("Nästan rätt: " + guess);
                break;
            }
        }
    }

    public void Compare(List<char> guess, List<char> target)
    {
        List<char> guessList = guess;
        List<char> targetList = target;
        FirstCompare(guessList, targetList);
        SecondCompare(guessList, targetList);

    }

}
