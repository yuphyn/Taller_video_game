using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Text puntaje1;
	public Text puntaje2;
    void Start()
    {
        puntaje1.text="Puntaje player 1: " + PlayerPrefs.GetInt("J1",0).ToString();
        puntaje2.text="Puntaje player 2: " + PlayerPrefs.GetInt("J2",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("return")) SceneManager.LoadScene("menu");  
    }
}
