using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private Score score;
    private void Start()
    {
        score = GameObject.FindObjectOfType<Score>();
        transform.FindChild("Score").GetComponent<Text>().text = score.score.ToString();
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void activateCredits()
    {

    }

}
