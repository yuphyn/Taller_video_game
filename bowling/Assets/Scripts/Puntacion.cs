using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntacion : MonoBehaviour
{	
	private int suelo=0;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    }

    void OnCollisionStay(Collision collision)
    {	//print("toco algo");
        if (collision.collider.name == "Bowling Pin" && block0==0){
            suelo=suelo+1;
            block0=1;
    	}
    	if (collision.collider.name == "Bowling Pin (1)" && block1==0){
            suelo=suelo+1;
            block1=1;
    	}
    	if (collision.collider.name == "Bowling Pin (2)" && block2==0){
            suelo=suelo+1;
            block1=2;
    	}

        if (collision.collider.name == "Bowling Pin (3)" && block3==0){
            suelo=suelo+1;
            block3=1;
    	}

        if (collision.collider.name == "Bowling Pin (4)" && block4==0){
            suelo=suelo+1;
            block4=1;
    	}

        if (collision.collider.name == "Bowling Pin (5)" && block5==0){
            suelo=suelo+1;
            block5=1;
    	}

        if (collision.collider.name == "Bowling Pin (6)" && block6==0){
            suelo=suelo+1;
            block6=1;
    	}

        if (collision.collider.name == "Bowling Pin (7)" && block7==0){
            suelo=suelo+1;
            block7=1;
    	}

        if (collision.collider.name == "Bowling Pin (8)" && block8==0){
            suelo=suelo+1;
            block8=1;
    	}

        if (collision.collider.name == "Bowling Pin (9)" && block9==0){
            suelo=suelo+1;
            block9=1;
    	}
    	print(suelo);

    }
}
