using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Helper class for showing total userscore when player ship is destroyed.
/// </summary>
public class ScoreMonitor : MonoBehaviour
{
	void Start ()
	{
	    var score = GetComponent<Text>();
	    score.text = ScoreTracker.CurrentScore.ToString();
        ScoreTracker.Reset();
	}
	
}
