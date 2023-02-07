using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DetectPlayer : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    private UnityEngine.AI.NavMeshAgent nav;


    private void Start()
    {
        nav.enabled = false;

    }
    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enemy.SetDestination(Player.position);

        }
        else
        {
            nav.enabled = false;

        }
    }

}






