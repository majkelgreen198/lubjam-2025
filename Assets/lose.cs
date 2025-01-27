using UnityEngine;
using UnityEngine.SceneManagement;


public class lose : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLosingScene = 5f; 
    


    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("oncollisionenter " + collision.gameObject.name);
        bool didCollideWithBaby = collision.gameObject.CompareTag("baby");
        if (didCollideWithBaby)
        {
            Invoke("showLoseScreen", delayBeforeLosingScene);
        }
    }

    private void showLoseScreen()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
