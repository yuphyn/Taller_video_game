using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamareControler : MonoBehaviour
{
	private float moveSpeed=10.0f;
	private int block=0;
	private int flag=50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
           	//Manejo de boton
        if(Input.GetKey(KeyCode.UpArrow)&& block==0) {//Boton a apretar para lanzar esfera
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            block=1;
      	}
        
        if(flag>0){ // Mantener movimiento
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            flag=flag-1;

        } 
    }
}
