﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

    private static string[] WordList = {"one.uno", "two.dos", "three.tres", "four.cuatro", "five.cinco",
                                    "six.seis", "seven.siete", "eight.ocho", "nine.nueve", "ten.diez"};

	public static string GetRandomWord()
    {
        int RandomIndex = Random.Range(0, WordList.Length);
        string randomWord = WordList[RandomIndex];

        return randomWord;
    }
}

/*private static string[] WordList = {"sidewalk", "robin", "three", "protect", "periodic",
                                    "somber", "majestic", "jump", "pretty", "wound", "jazzy",
                                    "memory", "join", "crack", "grade", "boot", "cloudy", "sick",
                                    "mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
                                    "weird", "cut", "parallel", "wood", "encouraging", "interrupt",
                                    "guide", "long", "chief", "mom", "signal", "rely", "abortive",
                                    "hair", "representative", "earth", "grate", "proud", "feel",
                                    "hilarious", "addition", "silent", "play", "floor", "numerous",
                                    "friend", "pizzas", "building", "organic", "past", "mute", "unusual",
                                    "mellow", "analyse", "crate", "homely", "protest", "painstaking",
                                    "society", "head", "female", "eager", "heap", "dramatic", "present",
                                    "sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
                                    "boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "scarce",
                                    "account", "spot", "thought", "distinct", "nimble", "practise", "cream",
                                    "ablaze", "thoughtless", "love", "verdict", "giant"     };
                                    */