/*
 * 
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public static class PlayGamesScript 
{
	public static void Start ()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
    
        PlayGamesPlatform.InitializeInstance(config);

        PlayGamesPlatform.Activate();

        SignIn();
	}
	
    public static void SignIn()
    {
        Social.localUser.Authenticate(success => { });
    }

    #region Achievements
    public static void UnlockAchievement(string id)
    {
        Social.ReportProgress(id, 100, success => { });
    }

    public static void IncrementAchievement(string id, int stepsToIncrement)
    {
        PlayGamesPlatform.Instance.IncrementAchievement(id, stepsToIncrement, success => { });
    }

    public static void ShowAchievementsUI()
    {
        Social.ShowAchievementsUI();
    }

    #endregion /Achievements

    #region Leaderboards

    public static void AddScoreToLeaderboard(string leaderboardID, long score)
    {
        Social.ReportScore(score, leaderboardID, success => { });
    }

    public static void ShowLeaderboardsUI()
    {
        Social.ShowLeaderboardUI();
    }

    #endregion /Leaderboards
}
*/