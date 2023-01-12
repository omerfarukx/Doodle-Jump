using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{


    public Transform hedef;

    void Update()
    {
        if (hedef.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, hedef.position.y, transform.position.z);
        }
    }
}
