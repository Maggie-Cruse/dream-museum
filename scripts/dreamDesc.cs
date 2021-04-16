using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dreamDesc : MonoBehaviour
{
    public string dream;
    public Text dreamText;
    
   
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GameController"))
        {
            dreamText.text = dream;
        }
    }




}
