using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonclick : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log(" quit");
    }

    public void PlayAgain()
    {
        Debug.Log("play again");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    
}
