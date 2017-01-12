using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    // Загружает сцену с переданным методу именем.
	public void LoadLevel(string name)
    {
		SceneManager.LoadScene(name);
	}

    // Загружает сцену со следующим индексом среди сцен в настройках билда.
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Выходит из приложения (только в десктопной сборке).
	public void QuitRequest()
    {
		Application.Quit ();
	}
}
