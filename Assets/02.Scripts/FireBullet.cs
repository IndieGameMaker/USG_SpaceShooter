using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    // 총알의 발사할 위치 정보
    public Transform firePos;
    // 총알 프리팹
    public GameObject bulletPrefab;

    // 총 발사 음원(AudioClip)
    public AudioClip fireSfx;

    [System.NonSerialized]
    // 오디오소스 컴포넌트
    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        Fire();
    }

    void Fire()
    {
        // 마우스 왼쪽 버튼을 클릭 할 때 마다
        if (Input.GetMouseButtonDown(0))
        {
            // 총알을 FirePos 위치에 생성
            // Instantiate (생성할_객체, 좌표값, 회전값)
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);

            // 총소리 발생
            audio.PlayOneShot(fireSfx, 0.8f);
        }
    }
}


/*
    AudioListener  - 1

    AudioSource  - 소리를 발생시키는 역할 - n
*/