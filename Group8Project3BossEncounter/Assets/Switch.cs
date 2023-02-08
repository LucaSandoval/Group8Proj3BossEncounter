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
    private void Start()
    {
        enableE = false;
        Boss.SetActive(true);

    }

    private void Update()
    {
        RaycastHit hit;
        active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDistance);

        if(Input.GetKeyDown(KeyCode.F) && active == true)
        {
            Debug.Log("switch activated");
            enableE = true;



            
        }
        if (Input.GetKeyDown(KeyCode.E) && enableE == true)
        {
           
                Boss.SetActive(false);
            Debug.Log("boss killed");

  
        }
    }
}
