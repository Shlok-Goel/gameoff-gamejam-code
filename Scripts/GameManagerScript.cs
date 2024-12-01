using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void LoadLevelScreen()
    {
        SceneManager.LoadScene("Levels");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
    

}
