using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rigidbody;  // publico/ tipo do componente / nome

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

//MOVIMENTO DE PERSONAGEM
     if( Input.GetKey("a") ==true) //Se a tecla "a" esta apertada ou seja == a true
     {
         rigidbody.AddForce(-2,0,0); // anda -2 em X
     }
     if(Input.GetKey("d") == true)//Se a tecla "d" esta apertada ou seja == a true 
     {
         rigidbody.AddForce(2,0,0); // anda 2 em X
     }
     if(Input.GetKey("x") ==true) // Lancamento 
     {
         rigidbody.AddForce(0,50,200);
     }   
    }
}
