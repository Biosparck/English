using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word{

    public string word;
    public string wordEs;
    private int TypeIndex;
    WordDisplay display;

    public Word(string _word, string _wordEs, WordDisplay _display)
    {
        word = _word;
        wordEs = _wordEs;
        TypeIndex = 0;

        display = _display;
        display.SetWord(wordEs);
    }

    public char GetNextLetter()
    {

        return word[TypeIndex];
    }

    public void TypeLetter(char c)
    {
        TypeIndex++;
        display.RemoveLetter(c,TypeIndex);
    }

    public bool WordTyped()
    {
        bool WordTyped = (TypeIndex>=word.Length);
        if (WordTyped)
        {
            display.RemoveWord();
        }
        return WordTyped;
    }


}
