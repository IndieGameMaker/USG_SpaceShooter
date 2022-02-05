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
    public new AudioSource audio;

    public MeshRenderer muzzleFlash;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        muzzleFlash = firePos.GetComponentInChildren<MeshRenderer>();
        // {컴포넌트}.enabled = true/false;
        muzzleFlash.enabled = false;
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

            // 총구화염 효과
            StartCoroutine(ShowMuzzleFlash()); //StartCoroutine("ShowMuzzleFlash");
        }
    }

    IEnumerator ShowMuzzleFlash()
    {
        // 회전처리
        /*
            난수 발생 (Random)

            Random.Range(min, max)

            난수 발생 범위
            1. Integer  ex)  Random.Range(0, 10)       ---> 0 ~ 9
            2. Float    ex)  Random.Range(0.0f, 10.0f) ---> 0.0f ~ 10.0f
        */
        // 불규칙한 각도를 산출
        float angle = Random.Range(0, 360);
        // {컴포넌트}.tranform
        muzzleFlash.transform.localRotation = Quaternion.Euler(0, 0, angle);

        // 불규칙한 스케일 적용
        float scale = Random.Range(1.0f, 3.0f);
        muzzleFlash.transform.localScale = Vector3.one * scale; // new Vector3(scale, scale, scale)

        // 불규칙한 텍스처 Offset 적용
        // (0,0) (0.5, 0) (0, 0.5) (0.5, 0.5)
        // (0, 1) * 0.5 => (0, 0.5f)
        Vector2 offset = new Vector2(Random.Range(0, 2), Random.Range(0, 2)) * 0.5f;
        muzzleFlash.material.mainTextureOffset = offset;

        muzzleFlash.enabled = true;

        yield return new WaitForSeconds(0.3f);

        muzzleFlash.enabled = false;
    }
}


/*
    AudioListener  - 1

    AudioSource  - 소리를 발생시키는 역할 - n
*/

/*
    코루틴 (Co-routine)
*/

/*
    쿼터니언 (Quaternion) : 사원수 (x, y, z, w) : 복소수 4차원 벡터

    Quaternion.LookRotation (Vector3)
    Quaternion.Euler(x, y, z);

    오일러각(0, 360) : 오일러 회전 (x -> y -> z)
    Gimbal Lock(짐벌락, 김벌락)











*/