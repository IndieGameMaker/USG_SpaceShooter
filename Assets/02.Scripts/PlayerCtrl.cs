using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.position += new Vector3(0, 0, 0.1f);
        // transform.position = transform.position + new Vector3(0, 0, 0.1f);
    }
}
