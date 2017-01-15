using UnityEngine;
using UnityEngine.UI;

public class ScoreMonitor : MonoBehaviour
{
	void Start ()
	{
	    var score = GetComponent<Text>();
	    score.text = ScoreTracker.CurrentScore.ToString();
        ScoreTracker.Reset();
	}
	
}
