using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float velocidade;
    public float força;
    public float vida; 
    public float stamina;

    //x > y x é maior que y
    //x < y x é menor que y
    //x >= y x é maior ou igual a y
    //x <= y x é menor ou igual a y
    //x == y x é igual a y
    //x != y x é diferente de y
    //x = y x recebe y
    //&& - E - AND

    private void Start()
    {
        Caminhar();
    }

    private void Update()
    {
        Atacar();  
        Morrer();  
        Correr(); 
    }

    public void Caminhar ()
    {
        Debug.Log("Caminhando");
    }   

     public void Correr ()
    {
        if (stamina > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Correndo");
            stamina -= 10 * Time.deltaTime;
            // Assuming running consumes 10 stamina 
        }
        else if (stamina <= 0)
        {
            Debug.Log("Sem estamina para correr");
            stamina += 3;
        }
        else
        {
            stamina += 3 * Time.deltaTime;
            if (stamina > 100)
            {
                stamina = 100;
            }
        }
    }   

     public void Atacar ()
    {

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Atacando");
            }
        
    }   

     public void Morrer ()
    {
        if (vida <= 0)
         { Debug.Log("Morreu"); }
    }   
}
