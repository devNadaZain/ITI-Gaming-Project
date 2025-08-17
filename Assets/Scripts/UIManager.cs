using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public void NewGame()
    {

        SceneManager.LoadScene("SampleScene");
    }


    public void settings()
    {
        mainMenuPanel.SetActive(false);
    }
    public void ExitGame()
    {
        //Application.Quit();
        Debug.Log("Game is exiting");
    }
}
