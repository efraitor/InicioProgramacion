using System.Collections;
using System.Collections.Generic;
using UnityEngine; //Esta librería contiene lo necesario para usar el motor Unity

/*
    Variable = pequeña porción de memoria RAM donde podemos guardar un valor, que puede ir cambiando
    Declaración de una variable -> (pública o privada), tipo, nombre(si son dos palabras, las escribimos juntas pero la segunda palabra empieza en mayúscula) = asignación
    Ejemplo:

    public tipo nombre = valor;
 */
public class Variables : MonoBehaviour //MonoBehaviour significa que este Script deriva de ahí, es decir puede usar las propiedades de Unity
{
    /*
     * INICIALIZACIÓN DE VARIABLES
    */
    //Variables públicas (accesibles desde el editor de Unity o desde otro Script)
    //int = número de tipo entero sin decimales, positivo o negativo
    public int myNumber = 30;
    //Variables privadas (sólo son accesibles desde este Script y se tiene en cuenta su lugar de definición con respecto al código)
    //Si no ponemos public o private, automáticamente es private
    private int total; //Si no le asigno ningún valor a una variable de tipo int es como si hubiésemos puesto un 0

    //Se llama antes de que empiece el juego
    private void Awake()
    {
        //Pondríamos las varibles o comportamientos que son necesarios antes de comience el juego
    }

    //Se llama cuando empieza el juego
    void Start()
    {
        //Pondríamos las variables o comportamientos que son necesarios una vez el juego ha comenzado

        //A la variable total le asignamos el valor de (myNumber - 5)
        total = myNumber - 5; //total = 25;

        //Nos sirve para mostrar por consola el resultado de total
        Debug.Log(total);
        //Hago una suma que se va a mostrar en la consola
        Debug.Log(6 + 5);
    }

    //Se llama una vez cada frame
    void Update()
    {
        //Pondríamos las variables o comportamientos que son necesarios mientras el juego se está ejecutando
    }
}
