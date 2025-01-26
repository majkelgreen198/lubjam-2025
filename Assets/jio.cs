using UnityEngine;
using UnityEngine.SceneManagement;

public class jio : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void GoToMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
