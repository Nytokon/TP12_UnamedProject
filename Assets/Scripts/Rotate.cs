using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed=10;
    public float aceleracion = 1;
    public bool juegoIniciado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Iniciador()
    {
        juegoIniciado = true;
    }
    void Update()
   {
        if (juegoIniciado)
        {
            speed += aceleracion * Time.deltaTime;
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
    }
     }

