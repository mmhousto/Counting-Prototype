using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal, vertical;
    [SerializeField]
    private float playerMoveSpeed = 50f;

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
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = -Input.GetAxisRaw("Vertical");
        transform.Translate((new Vector3(vertical, 0, horizontal).normalized * playerMoveSpeed) * Time.deltaTime);
    }

    void BoundPlayer()
    {
        if(transform.position.z > 16)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 16);
        }
        else if(transform.position.z < -16)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -16);
        }
        if (transform.position.x > 16)
        {
            transform.position = new Vector3(16, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -16)
        {
            transform.position = new Vector3(-16, transform.position.y, transform.position.z);
        }
    }

}
