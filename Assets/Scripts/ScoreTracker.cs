using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Keeps track of the user score. 
/// </summary>
public class ScoreTracker : MonoBehaviour
{
    public static int CurrentScore;
    private Text _scoreField;


    void Start()
    {
        _scoreField = GetComponent<Text>();
    }

    public void Score(int points)
    {
        CurrentScore += points;
        _scoreField.text = "Score: " + CurrentScore;
    }

    public static void Reset()
    {
        CurrentScore = 0;
    }
}
