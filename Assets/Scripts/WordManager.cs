using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour {

    public List<Word> words;
    public WordSpawner wordSpawner;
    public BorderCheck borderCheck;
    public GameObject Score;
    private bool hasActiveWord;
    private Word activeWord;
    public int score;
    public int hearts;
    public string[] palabras;




    public void AddWord()
    {
        palabras = WordGenerator.GetRandomWord().Split('.');

        Word word = new Word(palabras[0] , palabras[1] , wordSpawner.SpawnWord());

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter(letter);
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter){
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter(letter);
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {

            hasActiveWord = false;
            score += 10;
            words.Remove(activeWord);
            Score.GetComponent<Text>().text = "score: " + score +" hearts: " ;
        }
    }
}
