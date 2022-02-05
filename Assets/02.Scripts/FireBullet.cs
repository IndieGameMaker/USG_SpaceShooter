using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    // 총알의 발사할 위치 정보
    public Transform firePos;
    // 총알 프리팹
    public GameObject bulletPrefab;

    void Update()
    {
        // 마우스 왼쪽 버튼을 클릭 할 때 마다
        if (Input.GetMouseButtonDown(0))
        {
            // 총알을 FirePos 위치에 생성
            // Instantiate (생성할_객체, 좌표값, 회전값)
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
