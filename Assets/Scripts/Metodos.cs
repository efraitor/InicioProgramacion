using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    /*
     * INICIALIZACI�N DE VARIABLES
    */
    public int number1 = 5;
    public int number2 = 8;
    //string = cadena de caracteres que tenemos que asignarle a la variable entre comillas
    public string persona = "Antonio";
    //float = n�meros con parte decimal, al asignarle un valor debe acabar en f
    public float decimalNumber = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Llamamos al primer tipo de m�todo para que funcione al empezar el juego
        //AddTwoNumbers();
        //Llamamos al segundo tipo de m�todo en el que le damos los valores que queremos pasarle entre par�ntesis
        //AddTwoNumbers2(5, 8);
        //AddTwoNumbers2(6, 9);
        //Llamamos al tercer tipo de m�todo
        Debug.Log(AddTwoNumbers3(3, 4)); //Este Debug.Log mostrar� por consola el resultado de la suma, osea la variable result
        //int suma = AddTwoNumbers3(3,4); //As� podr�amos sacar el valor de result para usarlo en el m�todo Start    
        //Debug.Log(suma);

        //Saludamos a Antonio
        //Debug.Log("Hola " + persona);

        //Saludamos a las dos personas
        SayHello("Pablo", "Mar�a");
        //Multiplcar un n�mero entero por dos
        DoubleNumber(3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulso la tecla Space llamamos al primer tipo de m�todo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddTwoNumbers();
        }
    }

    //Primer tipo de m�todo, que coge variables de fuera y hace su acci�n
    public void AddTwoNumbers()
    {
        Debug.Log(number1 + number2);
    }

    //Segundo tipo de m�todo, las variables se pasan al m�todo y hace su acci�n cuando lo llamamos
    public void AddTwoNumbers2(int firstNumber, int secondNumber)//Los par�metros son valores o referencias que le tenemos que pasar al m�todo a la misma vez que lo llamamos para que funcione
    {
        Debug.Log(firstNumber + secondNumber);
    }

    //Tercer tipo de m�todo, le pasamos par�metros, el m�todo tiene tipo de variable y devuelve una variable de ese tipo elegido
    public int AddTwoNumbers3(int firstNumber, int secondNumber)
    {
        //Creo una variable privada del m�todo, para guardar el resultado de la suma
        int result = firstNumber + secondNumber;
        //Devuelvo el valor de la variable, que tiene que ser del mismo tipo que el del m�todo
        return result;
    }

    /*
     * Un m�todo que salude a la vez a dos personas dadas
     * Un m�todo que multiplique un n�mero decimal por dos
     * Ambos m�todos se mostrar�n por consola
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
