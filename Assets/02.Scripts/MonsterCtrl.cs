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

    }
}
