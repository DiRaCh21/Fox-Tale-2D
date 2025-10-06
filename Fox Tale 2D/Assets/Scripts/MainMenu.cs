using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startScene, continueScene, helpScene, aboutScene;
    public GameObject continueButton;

    private void Start()
    {
        if(PlayerPrefs.HasKey(startScene + " unlocked"))
        {
            continueButton.SetActive(true);

        }
        else
        {
            continueButton.SetActive(false);
        }
    
    }
    public void StartGame()
    {

        SceneManager.LoadScene(startScene);
        PlayerPrefs.DeleteAll();

    }

    public void LoadHelp()
    {
        SceneManager.LoadScene(helpScene);
    }
    
    public void LoadAbout()
    {
        SceneManager.LoadScene(aboutScene);
    }


    public void ContinueGame()
    {
        SceneManager.LoadScene(continueScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
