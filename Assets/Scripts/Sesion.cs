using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Sesion : MonoBehaviour {

    public Login Login;
    public GameObject Ruts;
    public GameObject Nombres;
    public string[] Usuario;

    string DatosURL = "http://localhost/English/Sesion.php";


    // Use this for initialization
    void Start () {
        StartCoroutine(Datos(Login.Rut));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Datos(string Rut)
    {
        WWWForm form = new WWWForm();
        form.AddField("RutPost", Rut);

        WWW www = new WWW(DatosURL, form);

        yield return www;

        Usuario = www.text.Split('.');

        Ruts.GetComponent<Text>().text += Usuario[0];
        Nombres.GetComponent<Text>().text += Usuario[1]+" "+Usuario[2];


    }

    public void LogOutButton()
    {
        Usuario = null;
        SceneManager.LoadScene("Login");
    }

}
