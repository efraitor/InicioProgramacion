using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public int age;
    public bool isMale;
    public bool isMarried;

    public Persona spouse;

    //Constructor de la clase persona por Defecto
    public Persona() 
    {

    }

    //Constructor de la clase Persona usando solo nombre y apellido
    public Persona(string pFirstName, string pLastName) 
    {
        //De esa persona concreta que estamos construyendo cojo el parámetro y lo meto en la variable que habíamos creado
        firstName = pFirstName;
        lastName = pLastName;
    }

    //Constructor de la clase Persona usando todos los datos
    public Persona(string pFirstName, string pLastName, int pAge, bool pIsMale, bool pIsMarried)
    {
        //De esa persona concreta que estamos construyendo cojo el parámetro y lo meto en la variable que habíamos creado
        firstName = pFirstName;
        lastName = pLastName;
        age = pAge;
        isMale = pIsMale;
        isMarried = pIsMarried;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsMarriedWith(Persona otherPerson)
    {
        //Compruebo primero si esa persona está casada o tiene esposo/a
        if(this.spouse == null) //si la persona que yo estoy comprobando está soltera, no tiene esposo/a
        {
            Debug.Log("No está casado/a");
            return false;
            //aquí no está casado/a
        }
        //Y si la persona está casado/a
        else
        {
            Debug.Log("Esta casado/a");
            //Si los nombres y apellidos de los esposos/as de las personas que estamos comprobando coinciden
            if(otherPerson.firstName == this.spouse.firstName &&
                otherPerson.lastName == this.spouse.lastName)
            {
                Debug.Log("Están casados entre sí");
                return true;
                //aquí está casado/a con otherPerson
            }
            //Y si está casado/a pero con otra persona distinta
            else
            {
                Debug.Log("Están casados/as pero no entre sí");
                return false;
                //aquí está casado/a pero no con otherPerson
            }
        }
    }
}
