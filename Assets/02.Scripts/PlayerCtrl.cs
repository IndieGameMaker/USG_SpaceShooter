using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float h, v, r;

    public float speed = 20.0f;

    void Start()
    {

    }

    void Update()
    {
        v = Input.GetAxis("Vertical");  // -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal");// -1.0f ~ 0.0f ~ +1.0f
        r = Input.GetAxis("Mouse X");

        //transform.Translate(방향 * 속도 * 변위)
        // 방향벡터 = (전후진벡터) + (좌우벡터)
        Vector3 dir = (Vector3.forward * v) + (Vector3.right * h);

        // 벡터의 정규화 {벡터}.normalized
        transform.Translate(dir.normalized * Time.deltaTime * speed);

        // 회전로직
        transform.Rotate(Vector3.up * 50.0f * Time.deltaTime * r);
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
