using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
public TextMeshProUGUI Txt_Tiempo;
    public float tiempo = 0;

    void Update()
    {
        tiempo += Time.deltaTime;
        Txt_Tiempo.text = tiempo.ToString("F0");
    }
}
