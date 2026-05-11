using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CollisionManager : MonoBehaviour
{
public TextMeshProUGUI Txt_Perdiste;
    // Start is called before the first frame update
    void Start()
    {
                            Txt_Perdiste.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player")){
            Destroy(col.gameObject);
                    Txt_Perdiste.gameObject.SetActive(true);
        }
        }
}
