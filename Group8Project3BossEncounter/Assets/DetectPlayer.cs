using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DetectPlayer : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public Switch switchScript;


    private void Start()
    {
        enemy.enabled = true;


    }
    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enemy.enabled = true;
            switchScript.inEnemyRange = true;
            enemy.SetDestination(Player.position);

        }
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            enemy.enabled = true;

            enemy.SetDestination(Player.position);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enemy.enabled = false;
            switchScript.inEnemyRange = true;

        }
    }

}