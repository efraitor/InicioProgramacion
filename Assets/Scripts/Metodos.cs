using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    /*
     * INICIALIZACIÓN DE VARIABLES
    */
    public int number1 = 5;
    public int number2 = 8;
    //string = cadena de caracteres que tenemos que asignarle a la variable entre comillas
    public string persona = "Antonio";
    //float = números con parte decimal, al asignarle un valor debe acabar en f
    public float decimalNumber = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Llamamos al primer tipo de método para que funcione al empezar el juego
        //AddTwoNumbers();
        //Llamamos al segundo tipo de método en el que le damos los valores que queremos pasarle entre paréntesis
        //AddTwoNumbers2(5, 8);
        //AddTwoNumbers2(6, 9);
        //Llamamos al tercer tipo de método
        Debug.Log(AddTwoNumbers3(3, 4)); //Este Debug.Log mostrará por consola el resultado de la suma, osea la variable result
        //int suma = AddTwoNumbers3(3,4); //Así podríamos sacar el valor de result para usarlo en el método Start    
        //Debug.Log(suma);

        //Saludamos a Antonio
        //Debug.Log("Hola " + persona);

        //Saludamos a las dos personas
        SayHello("Pablo", "María");
        //Multiplcar un número entero por dos
        DoubleNumber(3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulso la tecla Space llamamos al primer tipo de método
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddTwoNumbers();
        }
    }

    //Primer tipo de método, que coge variables de fuera y hace su acción
    public void AddTwoNumbers()
    {
        Debug.Log(number1 + number2);
    }

    //Segundo tipo de método, las variables se pasan al método y hace su acción cuando lo llamamos
    public void AddTwoNumbers2(int firstNumber, int secondNumber)//Los parámetros son valores o referencias que le tenemos que pasar al método a la misma vez que lo llamamos para que funcione
    {
        Debug.Log(firstNumber + secondNumber);
    }

    //Tercer tipo de método, le pasamos parámetros, el método tiene tipo de variable y devuelve una variable de ese tipo elegido
    public int AddTwoNumbers3(int firstNumber, int secondNumber)
    {
        //Creo una variable privada del método, para guardar el resultado de la suma
        int result = firstNumber + secondNumber;
        //Devuelvo el valor de la variable, que tiene que ser del mismo tipo que el del método
        return result;
    }

    /*
     * Un método que salude a la vez a dos personas dadas
     * Un método que multiplique un número decimal por dos
     * Ambos métodos se mostrarán por consola
    */
    void SayHello(string userName, string userName2)
    {
        Debug.Log("Hello " + userName + " y " + userName2);
    }

    void DoubleNumber(float number)
    {
        Debug.Log(2.0f * number);
    }
}
