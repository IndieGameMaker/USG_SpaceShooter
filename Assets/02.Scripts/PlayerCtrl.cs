using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // 게임데이터 초기화, 1회 호출, 스크립트가 비활성화 되어있어도 실행되는 특징
    void Awake()
    {

    }

    // 스크립트가 활성화 될때마다 호출됨.
    void OnEnable()
    {

    }

    // 1회 호출
    void Start()
    {

    }

    // 호출주기가 불규칙, 화면을 랜더링하는 주기와 일치
    void Update()
    {

    }

    // 정확한 시간간격으로 호출됨 (0.02초), 물리엔진의 계산주기
    void FixedUpdate()
    {

    }

    // Update 함수이후에 호출됨, Update함수에서 처리된 결괏값을 갖고 후처리 계산을 할때 사용하는 함수
    void LateUpdate()
    {

    }
}
