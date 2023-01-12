using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class seviye_olusturucu : MonoBehaviour
{
    public GameObject platformObjesi;
    public int platformSayisi;
    public float minX, maxX;
    public float minY, maxY;
    
    
    void Start()
    {
        Vector3 klonPozisyonu = new Vector3();

        for (int i = 0; i < platformSayisi; i++)
        {
            
            klonPozisyonu.x = Random.Range(minX, maxX);
            klonPozisyonu.y = Random.Range(minY, maxY);
            Instantiate(platformObjesi, klonPozisyonu, Quaternion.identity);
            

        }

    }

    void Update()
    {
        
    }
}
