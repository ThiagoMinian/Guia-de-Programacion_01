﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Crear una variable entera que pueda ser modificada desde el Inspector. Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error "El día ingresado no es válido".

public class Ejercicio8 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
        if (dia == 1)
        {
            Debug.Log("El día es domingo");
        }
        else if (dia == 2)
        {
            Debug.Log("El día es lunes");
        }
        else if (dia == 3)
        {
            Debug.Log("El día es martes");
        }
        else if (dia == 4)
        {
            Debug.Log("El día es miercoles");
        }
        else if (dia == 5)
        {
            Debug.Log("El día es jueves");
        }
        else if (dia == 6)
        {
            Debug.Log("El día es viernes");
        }
        else if (dia == 7)
        {
            Debug.Log("El día es sabado");
        }
        else
        {
            Debug.Log("Ingrese un numero valido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
