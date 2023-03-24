using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    public GameObject obj;
    Vector3 cord;
    void Start()
    {
        cord = obj.transform.position+ new Vector3(0,0.3f,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position = cord;
        }
    }
}
