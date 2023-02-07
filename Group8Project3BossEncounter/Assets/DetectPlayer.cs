using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public GameObject Boss;

    public Transform Player;
    public enum BossState//
    {
        Idle,
        Follow,
        Death,
    }
    private void Start()
    {
        this.GetComponent<Follow>().enabled = false;
    }

    private void OnTriggerEnter(Collider other )
    {
        if (other.tag == "Player")
        {
            this.GetComponent<Follow>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            this.GetComponent<Follow>().enabled = false;
        }
    }
}

