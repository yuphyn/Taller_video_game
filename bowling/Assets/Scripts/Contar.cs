using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Contar : MonoBehaviour
{
	[SerializeField] private GameObject pino0;
	[SerializeField] private GameObject pino1;
	[SerializeField] private GameObject pino2;
	[SerializeField] private GameObject pino3;
	[SerializeField] private GameObject pino4;
	[SerializeField] private GameObject pino5;
	[SerializeField] private GameObject pino6;
	[SerializeField] private GameObject pino7;
	[SerializeField] private GameObject pino8;
	[SerializeField] private GameObject pino9;
	private int suelo;
	private int block0=0;
	private int block1=0;
	private int block2=0;
	private int block3=0;
	private int block4=0;
	private int block5=0;
	private int block6=0;
	private int block7=0;
	private int block8=0;
	private int block9=0;
	private int flag=0;
	public Text puntaje;


	void Awake(){

	}
    // Start is called before the first frame update
    void Start()
    {	
    	Color var= Color.red;
    	suelo= PlayerPrefs.GetInt("J1",0);
    	int tipo=Random.Range(0,2);
    	int poder=Random.Range (0, 9);
    	puntaje.text="Puntaje: " + suelo.ToString();
    	if(tipo==0) var=Color.blue;
    	if(tipo==1) var=Color.red;
    	if(tipo==2) var=Color.green;
    	PlayerPrefs.SetInt("poderj1aj2",0); 
    	pino0.SetActive(true);
    	pino1.SetActive(true);
    	pino2.SetActive(true);
    	pino3.SetActive(true);
    	pino4.SetActive(true);
    	pino5.SetActive(true);
    	pino6.SetActive(true);
    	pino7.SetActive(true);
    	pino8.SetActive(true);
    	pino9.SetActive(true);

    	if(poder==0){
    		Renderer rend = pino0.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==1){
    		Renderer rend = pino1.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==2){
    		Renderer rend = pino2.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==3){
    		Renderer rend = pino3.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==4){
    		Renderer rend = pino4.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==5){
    		Renderer rend = pino5.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==6){
    		Renderer rend = pino6.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==7){
    		Renderer rend = pino7.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==8){
    		Renderer rend = pino8.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);    		
    	}
    	if(poder==9){
    		Renderer rend = pino9.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", var);

    	}   

    	//PlayerPrefs.DeleteAll()
    }

    // Update is called once per frame
    void Update()
    {	//Contar pinos en el suelo 
    	//puntaje.text="Puntaje: ";

    	if (pino0.transform.eulerAngles.z>30 && pino0.transform.eulerAngles.z<95 && block0==0){
    		Renderer rend = pino0.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10; 
    		suelo=suelo+1;
    		block0=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino0.SetActive(false);
    	}
    	if (pino0.transform.eulerAngles.z<-30 && pino0.transform.eulerAngles.z>-95 && block0==0){
    		Renderer rend = pino0.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block0=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino0.SetActive(false);
    	}
        if (pino1.transform.eulerAngles.z>30 && pino1.transform.eulerAngles.z<95 && block1==0){
        	Renderer rend = pino1.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block1=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino1.SetActive(false);
    	}
    	if (pino1.transform.eulerAngles.z<-30 && pino1.transform.eulerAngles.z>-95 && block1==0){
    		Renderer rend = pino1.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;    		
    		suelo=suelo+1;
    		block1=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino1.SetActive(false);
    	}
    	if (pino2.transform.eulerAngles.z>30 && pino2.transform.eulerAngles.z<95 && block2==0){
    		Renderer rend = pino2.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;    		
    		suelo=suelo+1;
    		block2=2;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino2.SetActive(false);
    	}
    	if (pino2.transform.eulerAngles.z<-30 && pino2.transform.eulerAngles.z>-95 && block2==0){
    		Renderer rend = pino2.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block2=2;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino2.SetActive(false);
    	}
    	if (pino3.transform.eulerAngles.z>30 && pino3.transform.eulerAngles.z<95 && block3==0){
    		Renderer rend = pino3.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block3=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino3.SetActive(false);
    	}
    	if (pino3.transform.eulerAngles.z<-30 && pino3.transform.eulerAngles.z>-95 && block3==0){
    		Renderer rend = pino3.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block3=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino3.SetActive(false);
    	}
    	if (pino4.transform.eulerAngles.z>30 && pino4.transform.eulerAngles.z<95 && block4==0){
    		Renderer rend = pino4.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block4=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino4.SetActive(false);
    	}
    	if (pino4.transform.eulerAngles.z<-30 && pino4.transform.eulerAngles.z>-95 && block4==0){
    		Renderer rend = pino4.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block4=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino4.SetActive(false);
    	}
    	if (pino5.transform.eulerAngles.z>30 && pino5.transform.eulerAngles.z<95 && block5==0){
    		Renderer rend = pino5.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block5=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino5.SetActive(false);
    	}
    	if (pino5.transform.eulerAngles.z<-30 && pino5.transform.eulerAngles.z>-95 && block5==0){
    		Renderer rend = pino5.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block5=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino5.SetActive(false);
    	}
    	if (pino6.transform.eulerAngles.z>30 && pino6.transform.eulerAngles.z<95 && block6==0){
    		Renderer rend = pino6.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block6=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino6.SetActive(false);
    	}
    	if (pino6.transform.eulerAngles.z<-30 && pino6.transform.eulerAngles.z>-95 && block6==0){
    		Renderer rend = pino6.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block6=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino6.SetActive(false);
    	}
    	if (pino7.transform.eulerAngles.z>30 && pino7.transform.eulerAngles.z<95 && block7==0){
    		Renderer rend = pino7.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block7=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino7.SetActive(false);
    	}
    	if (pino7.transform.eulerAngles.z<-30 && pino7.transform.eulerAngles.z>-95 && block7==0){
    		Renderer rend = pino7.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block7=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino7.SetActive(false);
    	}
    	if (pino8.transform.eulerAngles.z>30 && pino8.transform.eulerAngles.z<95 && block8==0){
    		Renderer rend = pino8.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block8=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino8.SetActive(false);
    	}
    	if (pino8.transform.eulerAngles.z<-30 && pino8.transform.eulerAngles.z>-95 && block8==0){
    		Renderer rend = pino8.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block8=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino8.SetActive(false);
    	}
    	if (pino9.transform.eulerAngles.z>30 && pino9.transform.eulerAngles.z<95 && block9==0){
    		Renderer rend = pino9.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block9=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino9.SetActive(false);
    	}
    	if (pino9.transform.eulerAngles.z<-30 && pino9.transform.eulerAngles.z>-95 && block9==0){
    		Renderer rend = pino9.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block9=1;
    		if(rend.material.color==Color.red) PlayerPrefs.SetInt("poderj1aj2",1);
    		pino9.SetActive(false);
    	}
    	if(Input.GetKey(KeyCode.UpArrow)) {
            flag=170;
      	}
      	if (flag==5){
      		//print(suelo);
      		puntaje.text="Puntaje: " + suelo.ToString();
      		PlayerPrefs.SetInt("J1",suelo);
      	}
    	flag=flag-1;
    }

}
