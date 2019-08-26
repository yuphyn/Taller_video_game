using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flecha;
    public GameObject lista;
    private int indice=0;
    void Start()
    {	
    	//Inicializar datos.
        PlayerPrefs.SetInt("J1",0);
        PlayerPrefs.SetInt("J2",0);
        Dibujar();
    }

    // Update is called once per frame
    void Update()
    {
    	bool up= Input.GetKeyDown("up");
    	bool down= Input.GetKeyDown("down");
    	if(up) indice--;
    	if(down) indice++;
        if(indice>lista.transform.childCount -1) indice=0;
        else if(indice <0) indice= lista.transform.childCount -1;
        if(up || down) Dibujar();

        if(Input.GetKeyDown("return")) Accion();
    }

    void Dibujar(){
    	Transform opcion=lista.transform.GetChild(indice);
    	flecha.transform.position= opcion.position; 
    }

    void Accion(){
    	if (indice==0){
    		Transform opcion=lista.transform.GetChild(indice);
    		SceneManager.LoadScene("jugador1");
    	}
    	if(indice==2){
    		Transform opcion=lista.transform.GetChild(indice);
    		SceneManager.LoadScene("informacion");    		
    	}
    }
}
