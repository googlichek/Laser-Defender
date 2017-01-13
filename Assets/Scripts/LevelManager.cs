using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Loads scene with a given name.
	public void LoadLevel(string name)
    {
		SceneManager.LoadScene(name);
	}

    // Loads scene with the next index in build settings scene order.
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Quits from application (only for desktop build).
	public void QuitRequest()
    {
		Application.Quit ();
	}
}
