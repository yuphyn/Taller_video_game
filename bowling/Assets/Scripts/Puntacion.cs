using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntacion : MonoBehaviour
{	
	private int suelo=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.name == "pino"){
            suelo=suelo+1;
            print(suelo);
        }
        if (collision.collider.name == "pino1"){
            suelo=suelo+1;
            print(suelo);
        }
        if (collision.collider.name == "pino2"){
            suelo=suelo+1;
            print(suelo);
        }
        if (collision.collider.name == "pino3"){
            suelo=suelo+1;
            print(suelo);
        }
        if (collision.collider.name == "pino4"){
           	suelo=suelo+1;
           	print(suelo);
        }
        if (collision.collider.name == "pino5"){
           	suelo=suelo+1;
           	print(suelo);
        }
        if (collision.collider.name == "pino6"){
           	suelo=suelo+1;
           	print(suelo);
        }
        if (collision.collider.name == "pino7"){
           	suelo=suelo+1;
           	print(suelo);
        }
        if (collision.collider.name == "pino8"){
           	suelo=suelo+1;
           	print(suelo);
        }
        if (collision.collider.name == "pino9"){
           	suelo=suelo+1;
           	print(suelo);
        }
        
    }
}
