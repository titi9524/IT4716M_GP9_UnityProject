using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    public static int player1Score = 0;
    public static int player2Score = 0;
    public static int player3Score = 0;
    public static int player4Score = 0;

    private bool allRoundFinished = false;

    private bool player1Wins = false;
    private bool player2Wins = false;
    private bool player3Wins = false;
    private bool player4Wins = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   


        if(allRoundFinished == true)
        {
            if(player1Score > player2Score && player1Score > player3Score && player1Score > player4Score)
            {
                player1Wins = true;
                SceneManager.LoadScene(5);
            }
            else if (player2Score > player1Score && player2Score > player3Score && player2Score > player4Score)
            {
                player2Wins = true;
                SceneManager.LoadScene(5);
            }

            else if (player3Score > player1Score && player3Score > player2Score && player3Score > player4Score)
            {
                player3Wins = true;
                SceneManager.LoadScene(5);
            }

            else if (player4Score > player1Score && player4Score > player2Score && player4Score > player3Score)
            {
                player4Wins = true;
                SceneManager.LoadScene(5);
            }
        }
    }
}
