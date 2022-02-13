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
        if (transform.Find("Score") != null)
            transform.Find("Score").GetComponent<Text>().text = score.score.ToString();
        if (transform.Find("TimeIsOver") != null)
            if (!score.time)
            {
                transform.Find("TimeIsOver").GetComponent<Text>().text = "Everything is solved!";


            }
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
