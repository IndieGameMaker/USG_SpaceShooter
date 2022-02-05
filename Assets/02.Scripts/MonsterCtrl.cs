using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // NavMeshAgent 관련 네임스페이스

public class MonsterCtrl : MonoBehaviour
{
    [SerializeField] private Transform monsterTr;
    [SerializeField] private Transform playerTr;

    private Animator anim;
    private NavMeshAgent agent;

    //추적 사정거리
    [Range(5.0f, 20.0f)]
    public float traceDist = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        monsterTr = transform; // GetComponent<Transform>();
        playerTr = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Transform>();

        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // 몬스터와 주인공간의 거리를 계산
        float distance = Vector3.Distance(playerTr.position, monsterTr.position);

        Debug.Log(distance);

        // 추적사정거리 범위여부를 판단
        if (distance <= traceDist)
        {
            agent.SetDestination(playerTr.position);
            // 추적 시작
            agent.isStopped = false;
            // 애니메이션 변경 Idle -> Walk : IsTrace = true
            anim.SetBool("IsTrace", true);
        }
        else
        {
            // 추적 정지
            agent.isStopped = true;
            // Walk -> Idle : IsTrace = false;
            anim.SetBool("IsTrace", false);
        }
    }
}
