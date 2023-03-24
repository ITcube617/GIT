using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private Animator anim;
    public GameObject body;
    public Camera cam;
    public Camera cam0;
    private void Start()
    {
        anim =GameObject.Find("Camera").GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("play"))
        {
            body.SetActive(true);
            anim.SetBool("Start",true);
            cam0.enabled = false;
            cam.enabled = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("play"))
        {
            cam0.enabled = true;
            cam.enabled = false;
        }
    }
}
