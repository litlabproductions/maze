using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGamesManager : MonoBehaviour
{

    public static PlayGamesManager Instance { get; private set;}
    public static int Counter { get; set; }

    // Use this for initialization
    void Start () {
        Instance = this;

        //Counter 
	}
	
    public void IncrementCounter()
    {
       // Counter++;
    }

    public void AddScoreToLeaderboard()
    {
        //PlayGamesScript.AddScoreToLeaderboard(GPGSIds.leaderboard_highscore, Counter);
        Counter = 0;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
