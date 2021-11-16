using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rigidbody;  // publico/ tipo do componente / nome
    public int Forca_X, Forca_Z=50;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()  //Boas praticas Unity == Tudo q for trabalhar com fisica, é bom usar FixedUpdate !
    {

//MOVIMENTO DE PERSONAGEM
    rigidbody.AddForce(0,0,Forca_Z);
     if( Input.GetKey("a") ==true) //Se a tecla "a" esta apertada ou seja == a true
     {
         rigidbody.AddForce(-Forca_X*Time.fixedDeltaTime,0,0); // anda -2 em X  //usando variaveis em vez de numero interios  (boas praticas)
     }
     if(Input.GetKey("d") == true)//Se a tecla "d" esta apertada ou seja == a true 
     {
         rigidbody.AddForce(Forca_X*Time.fixedDeltaTime,0,0); // anda 2 em X
         //time.fixedDeltaTime == traz pra realidade(n faz a soma da variaveis toda vez por frame)
         // ou seja-> X*0.016 em vez de X*FPS
     }
     if(Input.GetKey("x") ==true) // Lancamento   // N esta usando boas praticas Unity
     {
         rigidbody.AddForce(0,50,200);
     }   
    }
}
