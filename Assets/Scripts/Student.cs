using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{
    public string firstName = "Juan Alberto";
    public string lastName = "Martínez";
    public string email = "jamartinez@esimurcia.com";
    public int edad = 32;
    public int curso = 3;
    public float precioMatricula = 2500.57f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Para saber cuanto tiempo está el juego en marcha y mostrarlo por consola
        //Debug.Log(Time.time); //time = tiempo que ha pasado desde que empezó un frame hasta que termina

        //Calculamos la altura a la que se encuentra el GameObject que tiene el script asociado
        float testObjectHeight = this.transform.position.y; //leer al revés (this = objeto donde está metido el script)
        Debug.Log(testObjectHeight);
    }

    /*Método de Unity que funciona parecido al Update, es decir va a unos frames por segundo,
    * pero sus frames tienen el mismo tamaño. Por ejemplo en vez de ir a 30 fps, va a 12-15 fps
    * Sirve para hacer un movimiento suavizado al usar físicas
    */
    void FixedUpdate()
    {
        //Debug.Log(Time.time);
    }
}
