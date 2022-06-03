using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyBallBelowLevel();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

    void DestroyBallBelowLevel()
    {
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }
}
