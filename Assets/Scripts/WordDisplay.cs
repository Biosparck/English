using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

    public Text text;
    public float moveSpeed = 1f;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter(char c,int index)
    {
        if (index == 1)
        {
            text.text += " - ";
        }
        text.text += c;
        text.color = Color.green;

    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(-moveSpeed*Time.deltaTime,0f,0f);
    }

}
