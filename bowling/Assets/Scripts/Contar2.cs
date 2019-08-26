using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Contar2 : MonoBehaviour
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
    	PlayerPrefs.SetInt("PuntosactualesJ1",0);
    	suelo= PlayerPrefs.GetInt("J2",0);
    	int poder=Random.Range (0, 9);
    	puntaje.text="Puntaje: " + suelo.ToString();
    	if(poder==0){
    		Renderer rend = pino0.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==1){
    		Renderer rend = pino1.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==2){
    		Renderer rend = pino2.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==3){
    		Renderer rend = pino3.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==4){
    		Renderer rend = pino4.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==5){
    		Renderer rend = pino5.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==6){
    		Renderer rend = pino6.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==7){
    		Renderer rend = pino7.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==8){
    		Renderer rend = pino8.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
    	}
    	if(poder==9){
    		Renderer rend = pino9.GetComponent<Renderer>();
        	rend.material.shader = Shader.Find("Specular");
        	rend.material.SetColor("_Color", Color.blue);    		
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
    	}
    	if (pino0.transform.eulerAngles.z<-30 && pino0.transform.eulerAngles.z>-95 && block0==0){
    		Renderer rend = pino0.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block0=1;
    	}
        if (pino1.transform.eulerAngles.z>30 && pino1.transform.eulerAngles.z<95 && block1==0){
        	Renderer rend = pino1.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block1=1;
    	}
    	if (pino1.transform.eulerAngles.z<-30 && pino1.transform.eulerAngles.z>-95 && block1==0){
    		Renderer rend = pino1.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;    		
    		suelo=suelo+1;
    		block1=1;
    	}
    	if (pino2.transform.eulerAngles.z>30 && pino2.transform.eulerAngles.z<95 && block2==0){
    		Renderer rend = pino2.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;    		
    		suelo=suelo+1;
    		block2=2;
    	}
    	if (pino2.transform.eulerAngles.z<-30 && pino2.transform.eulerAngles.z>-95 && block2==0){
    		Renderer rend = pino2.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block2=2;
    	}
    	if (pino3.transform.eulerAngles.z>30 && pino3.transform.eulerAngles.z<95 && block3==0){
    		Renderer rend = pino3.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block3=1;
    	}
    	if (pino3.transform.eulerAngles.z<-30 && pino3.transform.eulerAngles.z>-95 && block3==0){
    		Renderer rend = pino3.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block3=1;
    	}
    	if (pino4.transform.eulerAngles.z>30 && pino4.transform.eulerAngles.z<95 && block4==0){
    		Renderer rend = pino4.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block4=1;
    	}
    	if (pino4.transform.eulerAngles.z<-30 && pino4.transform.eulerAngles.z>-95 && block4==0){
    		Renderer rend = pino4.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block4=1;
    	}
    	if (pino5.transform.eulerAngles.z>30 && pino5.transform.eulerAngles.z<95 && block5==0){
    		Renderer rend = pino5.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block5=1;
    	}
    	if (pino5.transform.eulerAngles.z<-30 && pino5.transform.eulerAngles.z>-95 && block5==0){
    		Renderer rend = pino5.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block5=1;
    	}
    	if (pino6.transform.eulerAngles.z>30 && pino6.transform.eulerAngles.z<95 && block6==0){
    		Renderer rend = pino6.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block6=1;
    	}
    	if (pino6.transform.eulerAngles.z<-30 && pino6.transform.eulerAngles.z>-95 && block6==0){
    		Renderer rend = pino6.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block6=1;
    	}
    	if (pino7.transform.eulerAngles.z>30 && pino7.transform.eulerAngles.z<95 && block7==0){
    		Renderer rend = pino7.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block7=1;
    	}
    	if (pino7.transform.eulerAngles.z<-30 && pino7.transform.eulerAngles.z>-95 && block7==0){
    		Renderer rend = pino7.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block7=1;
    	}
    	if (pino8.transform.eulerAngles.z>30 && pino8.transform.eulerAngles.z<95 && block8==0){
    		Renderer rend = pino8.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block8=1;
    	}
    	if (pino8.transform.eulerAngles.z<-30 && pino8.transform.eulerAngles.z>-95 && block8==0){
    		Renderer rend = pino8.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block8=1;
    	}
    	if (pino9.transform.eulerAngles.z>30 && pino9.transform.eulerAngles.z<95 && block9==0){
    		Renderer rend = pino9.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block9=1;
    	}
    	if (pino9.transform.eulerAngles.z<-30 && pino9.transform.eulerAngles.z>-95 && block9==0){
    		Renderer rend = pino9.GetComponent<Renderer>();
    		if(rend.material.color==Color.blue) suelo=suelo+10;
    		suelo=suelo+1;
    		block9=1;
    	}
    	if(Input.GetKey(KeyCode.UpArrow)) {
            flag=200;
      	}
      	if (flag==5){
      		//print(suelo);
      		puntaje.text="Puntaje: " + suelo.ToString();
      		PlayerPrefs.SetInt("J2",suelo);
      	}
    	flag=flag-1;
    }

}
