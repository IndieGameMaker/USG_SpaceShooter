using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public GameObject sparkEffect;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "BULLET")
        {
            Destroy(coll.gameObject);

            // 스파크 발생(스파크 Instantiate)
        }
    }
}

/*
    충돌 콜백함수 (Collision Dectect Callback Function/Event)

    1. 양쪽 다 Collider 컴포넌트가 존재
    2. 이동하는 물체에 Rigidbody 컴포넌트가 존재

    IsTrigger 속성이 언체크일 경우
    OnCollisionEnter --- 1
    OnCollisionStay  --- n
    OnCollisionExit  --- 1

    IsTrigger 속성이 체크일 경우
    OnTriggerEnter
    OnTriggerStay
    OnTriggerExit
*/