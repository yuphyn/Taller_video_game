using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_aroow : MonoBehaviour
{
	public float turnSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	//movimiento
    	if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
        	transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);
        //Destrución
        /*if(Input.GetKey(KeyCode.UpArrow))
        	gameObject.SetActive(false);
            //Destroy(gameObject); */
    }
}
