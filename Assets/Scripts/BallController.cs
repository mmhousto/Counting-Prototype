using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public GameObject particleSystem;

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
            Instantiate(particleSystem, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    void DestroyBallBelowLevel()
    {
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
            Lives.Instance.LoseLife();
        }
    }
}
