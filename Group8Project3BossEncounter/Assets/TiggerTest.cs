using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerTest : MonoBehaviour
{
    public GameObject prompt;

    public void Show(GameObject prompt)
    {

        prompt.SetActive(true);
    }
    public void Hide(GameObject prompt)
    {
        prompt.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(Time.time + ":����ô������Ķ����ǣ�" + other.gameObject.name);
        Show(prompt);
    }
    void OnTriggerStay(Collider other) 
    {
        Debug.Log(Time.time + "���ڴ������Ķ����ǣ�" + other.gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log(Time.time + "�뿪�������Ķ����ǣ�" + other.gameObject.name);
        Hide(prompt);
    }

    // Start is called before the first frame update
    void Start()
    {
        Hide(prompt);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
