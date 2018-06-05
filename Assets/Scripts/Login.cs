using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {

    public string InputuserName;
    public string Inputpassword;
    public GameObject ErrorMessage;
    public GameObject Username;
    public GameObject Password;
    public static string Rut;

    string LoginURL = "http://localhost/English/Login.php";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        InputuserName = Username.GetComponent<InputField>().text;
        Inputpassword = Password.GetComponent<InputField>().text;

    }

    public void LoginButton()
    {
       StartCoroutine(LoginToGame(InputuserName, Inputpassword));
    }

    IEnumerator LoginToGame(string username,string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("RutPost", username);
        form.AddField("PassPost", password);

        WWW www = new WWW(LoginURL, form);

        yield return www;

        if(www.text == "login success")
        {
            Rut = username;
            
            SceneManager.LoadScene("Main Menu");
        }
        else
        {
            ErrorMessage.GetComponent<Text>().text = www.text;

            Debug.Log(www.text);
        }

    }
}
