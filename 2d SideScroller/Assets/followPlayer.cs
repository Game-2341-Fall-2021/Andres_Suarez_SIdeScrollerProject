using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform Playertofollow;
    public Vector3 offset;
    public float xoffset, yoffset;
    Vector3 offsetposition;
    // Start is called before the first frame update
    void Start()
    {
        offset = Vector3.right * -3;
    }

    // Update is called once per frame
    void Update()
    {
        offsetposition = new Vector3(xoffset, yoffset, 0);
        gameObject.transform.LookAt((Playertofollow.position+ offset));

        if(Input.GetMouseButton(3))
        {
            xoffset += .01f;
        }
        if (Input.GetMouseButton(4))
        {
            yoffset += .01f;
        }

    }
}
