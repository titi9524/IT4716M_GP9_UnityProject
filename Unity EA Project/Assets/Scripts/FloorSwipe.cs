using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSwipe : MonoBehaviour
{
    public Material playerMaterial;
    public GameObject Floor;
    public float gameTimer = 30;
    public int score;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        Floor = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameTimer >0)
        {
            gameTimer -= Time.deltaTime;
        }

        if(gameTimer <= 0)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerMaterial = other.gameObject.GetComponent<Renderer>().material;
            Floor.GetComponent<Renderer>().material = playerMaterial;
            ScoreBoard.player1Score++;
        }

    }

}
