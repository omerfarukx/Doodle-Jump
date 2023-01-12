using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temizle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D temas)
    {
        float rastgeleX = Random.Range(-3f, 3f);
        
        

        if (temas.tag == "Platform")
        {
            temas.transform.position = new Vector3(rastgeleX,temas.transform.position.y +Random.Range(12f,14f), transform.position.z);
            
        }
        else if (temas.tag == "Altin")
        {
            temas.transform.position = new Vector3(rastgeleX, temas.transform.position.y + Random.Range(12f, 14f), transform.position.z);
            

        }
    }
}
