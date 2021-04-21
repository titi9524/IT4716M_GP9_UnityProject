using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    
    public GameObject Player;
    public float explodeTimer = 30;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (explodeTimer > 0)
        {
            explodeTimer -= Time.deltaTime;
        }

        if (explodeTimer <= 0)
        {
            Destroy(gameObject);
            Destroy(transform.parent.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" )
        {
            GameObject.FindGameObjectWithTag("Bomb").transform.SetParent(collision.transform);
        }

    }
}
