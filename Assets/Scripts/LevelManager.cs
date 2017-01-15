using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    /// <summary>
    /// Loads scene with a given name. 
    /// </summary>
    /// <param name="name">Scene name.</param>
	public void LoadLevel(string name)
    {
		SceneManager.LoadScene(name);
	}

    /// <summary>
    /// Loads scene with the next index in build settings scene order. 
    /// </summary>
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /// <summary>
    /// Quits from application (only for desktop build). 
    /// </summary>
	public void QuitRequest()
    {
		Application.Quit ();
	}
}
