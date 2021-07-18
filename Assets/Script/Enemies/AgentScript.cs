using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    [SerializeField] Transform target;
    private bool move;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        move = true;
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.bombSetted)
        {            
            if (GetComponent<EnemySpriteChanger>().dirtyFarmer && GameManager.instance.bombExploded)
            {
                move = false;
            }
        }
        if (!move)
        {
            target = GameObject.FindGameObjectWithTag("Bomb").transform;
        }
        agent.SetDestination(target.position);
    }
}
