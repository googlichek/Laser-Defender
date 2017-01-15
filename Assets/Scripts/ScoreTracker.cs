using UnityEngine;
using UnityEngine.UI;

// Keeps track of the user score.
public class ScoreTracker : MonoBehaviour
{
    private Text _scoreField;
    private int _currentScore;


    void Start()
    {
        _scoreField = GetComponent<Text>();
    }

    public void Score(int points)
    {
        _currentScore += points;
        _scoreField.text = "Score: " + _currentScore;
    }

    private void Reset()
    {
        _currentScore = 0;
        _scoreField.text = "Score: " + _currentScore;
    }
}
