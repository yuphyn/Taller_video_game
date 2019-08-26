﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class esfera : MonoBehaviour
{
    public float moveSpeed = 8f; //Fuerza
    public float turnSpeed = 50f; //rotacion
    private int flag;
    private int block;
    public Slider fuerza;
    private int energia= 0;
    private float var=0.0f;
    private Vector3 posini;
    private int lanzamiento=0;
    public GameObject arrow;

	void Start(){
		flag= 0;
		block=0;
		posini= transform.localPosition;
    }
    
    
    void Update ()
    {	
    	if(lanzamiento<2){
    		//Manejo de fuerza
    		var=var+0.1f;
    		if (energia>=100 && block==0){	
    			energia=0;
    			fuerza.value=energia;
    			moveSpeed=8f;
    		}
    		if(energia<100 && var>1.0f && block==0){
    			var=0.0f;
    			fuerza.value=energia;
    			energia=energia+10;
    			moveSpeed=moveSpeed+1f;
    		}

    		//Manejo de boton
        	if(Input.GetKey(KeyCode.UpArrow)&& block==0) {//Boton a apretar para lanzar esfera
        		arrow.SetActive(false);
            	transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            	flag=100;
            	block=1;
            	
      		}
        
        	if(flag>1){ // Mantener movimiento
            	transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            	flag=flag-1;
	        }
        	if(flag==1){
        		transform.localPosition =posini;
        		arrow.SetActive(true);
        		flag=0;
        		block=0;
        		var= 0.0f;
        		lanzamiento=lanzamiento+1;
        	}
        	//manejo rotacion
        	if(Input.GetKey(KeyCode.LeftArrow)){ //Rotacion
        		if(block==0)
            		transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        	}
        	if(Input.GetKey(KeyCode.RightArrow)){
        		if(block==0){
        			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        		}
        	}
    	}
    }

    void OnCollisionStay(Collision collision)
    {	

        if (collision.collider.name == "pared"){
            transform.localPosition =posini;
            flag=1;
        }
    }
     
}