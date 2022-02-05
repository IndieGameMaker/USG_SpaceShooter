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
            // Instantiate(객체, 좌표, 회전)
            // 충돌지점 산출
            ContactPoint cp = coll.GetContact(0);
            // 충돌 좌표
            Vector3 pos = cp.point;
            // 충돌 좌표기준으로의 법선벡터
            Vector3 contactNormal = -cp.normal;
            // 벡터가 바로보는 각도를 쿼터니언(Quaternion) 타입으로 변환
            Quaternion rot = Quaternion.LookRotation(contactNormal);

            // 스파크 생성
            GameObject obj = Instantiate(sparkEffect, pos, rot);
            Destroy(obj, 0.4f);
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