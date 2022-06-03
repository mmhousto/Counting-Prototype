using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        BoundPlayer();
    }

    void MovePlayer()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, 0, horizontal * 20f) * Time.deltaTime);
    }

    void BoundPlayer()
    {
        if(transform.position.z > 16)
        {
            transform.position = new Vector3(0, 0, 16);
        }
        else if(transform.position.z < -16)
        {
            transform.position = new Vector3(0, 0, -16);
        }
    }

}
