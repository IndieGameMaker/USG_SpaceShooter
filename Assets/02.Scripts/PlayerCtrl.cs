using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float h, v, r;

    void Start()
    {

    }

    void Update()
    {
        v = Input.GetAxis("Vertical");

        //transform.position += new Vector3(0, 0, 0.1f);
        transform.Translate(Vector3.forward * 0.1f);

    }

    /*
        정규화벡터(Normalized Vector), 단위벡터(Unit Vector) : 크기가 1인 벡터의 단위
        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.one  = Vector3(1, 1, 1)
        Vector3.zero = Vector3(0, 0, 0)
    */
}
