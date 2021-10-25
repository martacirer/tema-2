using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle : MonoBehaviour
{
    // Variable que guarda el sonido del vehiculo
    [SerializeField] private string sound = "¡Brum, Brum!";
    [SerializeField] private string name; // nombre del vehiculo
    [SerializeField] private int numberWheels = 4; // numero de ruedas

    
    // variable indica si el vehiculo etsá en marcha
   [SerializeField] private bool isOn = true;
   [SerializeField] private bool hasSiren;
    
   [SerializeField] private float gasoline;
    void Start()
    {
     /*Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");*/



         if (isOn) 
        {
            Debug.Log(sound);
        } else if (hasSiren == true)
        {
            Debug.Log($"{name} hara {sound} cuando se ponga en marcha");
        }
        else 
        {
            Debug.Log($"{name} no esta en marcha");
        }

       
        
        
        
        if (gasoline <= 10 && isOn == true )
        {
            Debug.Log($"¡A {name} le queda poca gasolina!");
            if (hasSiren)
            {
                Debug.Log($"sound");
            }
            else
            {
                Debug.Log($"{name}no tiene sirena");
            }

        }

 }

// Update is called once per frame
void Update()
    {
        
    }
}
