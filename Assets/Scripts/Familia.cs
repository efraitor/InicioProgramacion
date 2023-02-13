using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Familia : MonoBehaviour
{
    //Estas personas derivan de la clase persona (usamos información de esa clase)
    public Persona father;
    public Persona mother;
    public Persona son;

    // Start is called before the first frame update
    void Start()
    {
        //Aquí estaría usando el constructor por defecto para definir al padre
        //father = new Persona(); //Instanciando la nueva persona (inicializando)
        //father.firstName = "Juan Alberto"; //después de instanciar, podemos inicializar las variables
        //father.lastName = "Martínez";
        father.age = 32;
        father.isMale = true;
        father.isMarried = true;
        //Aquí usaríamos el segundo tipo de constructor que hemos creado
        father = new Persona("Juan Alberto", "Martínez");
        //Aquí usaríamos el tercer tipo de constructor que hemos creado
        //father = new Persona("Juan Alberto", "Martínez", 32, true, true);

        //mother = new Persona("Alicia", "Fernández", 30, false, true);
        //mother = new Persona();
        //mother.firstName = "Alicia";
        //mother.lastName = "Fernández";
        //mother.age = 30;
        //mother.isMale = false;
        mother.isMarried = true;

        //El padre tiene como esposa a la madre
        father.spouse = mother;
        //La madre tiene como esposo al padre
        mother.spouse = father;
        //Compruebo si esas dos personas están casadas entre sí
        if (father.IsMarriedWith(mother))
        {
            Debug.Log(father.firstName + " y " + mother.firstName + " están casados.");
        }
        else
        {
            Debug.Log(father.firstName + " y " + mother.firstName + " no están casados.");
        }

        son = new Persona();
        son.firstName = "Gabriel";
        son.lastName = "Martínez";
        son.age = 7;
        son.isMale = true;
        son.isMarried = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
