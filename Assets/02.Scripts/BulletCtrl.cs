using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // 총알의 로컬기준의 좌표계로 힘(Force)를 가하는 함수(메소드)
        rb.AddRelativeForce(Vector3.forward * 800.0f); // 800 뉴튼 (N)
    }

}
