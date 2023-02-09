using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Transform cam;
    public float playerActivateDistance;
    bool active = false;
    private bool enableE;
    public GameObject Boss;
    public GameObject text;

    public GameObject gunModel;

    public bool inEnemyRange;
    private void Start()
    {
        enableE = false;
        Boss.SetActive(true);
        text.SetActive(false);
        inEnemyRange = false;
        gunModel.SetActive(true);
    }

    private void Update()
    {
        RaycastHit hit;
        active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDistance);

        if(Input.GetKeyDown(KeyCode.F) && active == true)
        {
            Debug.Log("switch activated");
            enableE = true;
            text.SetActive(true);
            gunModel.SetActive(false);


        }
        if (Input.GetKeyDown(KeyCode.E) && enableE == true && inEnemyRange)
        {
           
                Boss.SetActive(false);
            Debug.Log("boss killed");

  
        }
    }
}
