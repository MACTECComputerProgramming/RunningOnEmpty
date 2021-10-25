using UnityEngine;
using UnityEngine.SceneManagement;

public class playclick : MonoBehaviour
{

    public void StartGame()
    {
        Debug.Log("play!");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
}
