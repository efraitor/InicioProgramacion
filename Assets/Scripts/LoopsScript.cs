using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        /*
         * FOREACH -> iterar sobre los elementos de una colección
         * foreach (Type elementName in collection){
         *  //Código del bucle
         * }
        */

        //Creamos una lista de nombres de estudiantes que luego podemos usar
        List<string> studentNames = new List<string>();
        studentNames.Add("Christian");
        studentNames.Add("Kate");
        studentNames.Add("Mia");
        studentNames.Add("Robert");

        Debug.Log("IMPRIMIENDO CON FOREACH");
        foreach (string person in studentNames)
        {
            //Que cada recorrido del bucle, person tiene un valor distinto
            Debug.Log(person);
        }

        //Vuestra nota
        int[] someInts = new int[] { 4, 8, 3, 0, 9, 6, 8, 7 }; //las notas
        int sum = 0; //suma total de las notas
        int n = someInts.Length; //número de notas
        foreach(int i in someInts)
        {
            sum = sum + i; //El valor total de la suma en cada iteración del bucle
            Debug.Log("La suma vale ahora: " + sum);
        }
        Debug.Log("La media de los números vale: " + sum / n);

        /*
         * FOR -> acceder a posiciones
         * for (inicialización; condición de continuación; iterador)
         * {
         *  //Código del bucle
         * }
        */
        Debug.Log("IMPRIMIENDO CON EL FOR");
        Debug.Log("Contar de 1 a 10");
        for (int i = 1; i <= 10; i++) //i++ <-> i = i + 1; <-> i += 1;
        {
            Debug.Log(i);
        }

        Debug.Log("Contar de 10 a 0");
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log(i);
        }

        for(int pos = 0; pos < studentNames.Count; pos++)
        {
            Debug.Log("El elemento número: " + pos + " de la lista es " + studentNames[pos]);
        }

        /*
         * WHILE
         * Inicialización
         * while (condición de continuación)
         * {
         *  //código a ejecutar
         *  iterador
         * }
         * La variable del bucle sigue existiendo después
        */
        Debug.Log("Contar de 1 a 10 con bucle WHILE");
        int counter = 1;
        while (counter <= 10)
        {
            Debug.Log(counter);
            counter++;
        }

        //Bucle que mientras no llueve, fiestaca en la playa
        bool isRaining = false;
        while (!isRaining)
        {
            //fiesta rave

            //comprobando si llueve y de repente lo hace
            isRaining = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
