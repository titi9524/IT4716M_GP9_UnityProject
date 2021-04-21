using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HotPotato : MonoBehaviour
{
    public GameObject cube;
    public GameObject Player;
    public GameObject[] playerCount;
    public int playerNum;


    // Start is called before the first frame update
    void Start()
    {
        playerCount = GameObject.FindGameObjectsWithTag("Player");
        playerNum = playerCount.Length;
        Player = GameObject.FindGameObjectWithTag("Player");
        GameObject clone = (GameObject)Instantiate(cube, Player.transform.position, Player.transform.rotation);

        clone.transform.parent = Player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (GameObject.FindGameObjectWithTag("Bomb") == null && playerNum != 1)
        {
            GameObject clone = (GameObject)Instantiate(cube, Player.transform.position, Player.transform.rotation);

            clone.transform.parent = Player.transform;
        }

        if(playerNum == 1)
        {
            SceneManager.LoadScene(3);
        }
    }
}


