using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int answer;
    private int figureValue;
    bool correct;
    [SerializeField] private GameObject listIsometric;
    [SerializeField] private GameObject listViews;
    [SerializeField] private Countdown countdown;

    private GameObject isometricFigure;
    private GameObject viewFigure;

    private GameObject tempGO;
    private GameObject tempGOView;

    public GameObject[] listObjectsIsometrics;
    public GameObject[] listObjectsViews;
    // Start is called before the first frame update
    void Start()
    {
        figureValue = 0;
        createList(listIsometric.transform.childCount);
        Shuffle();
        activateFigures(figureValue);
        
    }
    void createList(int numObjects)
    {
        listObjectsIsometrics = new GameObject[numObjects];
        listObjectsViews = new GameObject[numObjects];
        for (int i = 0; i < numObjects; i++)
        {
            listObjectsIsometrics[i] = listIsometric.transform.GetChild(i).gameObject;
            listObjectsViews[i] = listViews.transform.GetChild(i).gameObject;
        }
    }

    void Shuffle()
    {
        Debug.Log(listObjectsIsometrics.Length);
        for(int i = 0; i < listObjectsIsometrics.Length; i++)
        {
            int rnd = Random.Range(0, listObjectsIsometrics.Length);
            
            //Randomize listOfGameObjects Isometrics
            tempGO = listObjectsIsometrics[rnd];
            listObjectsIsometrics[rnd] = listObjectsIsometrics[i];
            listObjectsIsometrics[i] = tempGO;
            //Randomize Views GameObjects
            tempGOView = listObjectsViews[rnd];
            listObjectsViews[rnd] = listObjectsViews[i];
            listObjectsViews[i] = tempGOView;

        }
    }
    
    private void activateFigures(int index)
    {
        isometricFigure = listObjectsIsometrics[index];
        viewFigure = listObjectsViews[index];
        isometricFigure.SetActive(true);
        viewFigure.SetActive(true);
        answer = isometricFigure.GetComponent<AnswerInfo>().answer;
        //isometricFigure = listIsometric.transform.GetChild(index).gameObject;
        //viewFigure = listViews.transform.GetChild(index).gameObject;
        //isometricFigure.SetActive(true);
        //viewFigure.SetActive(true);
        ////listViews.transform.GetChild(index).gameObject.SetActive(true);
        //answer = isometricFigure.GetComponent<AnswerInfo>().answer;
    }
    private void deleteFigures(int index)
    {
        
        Destroy(isometricFigure);
        Destroy(viewFigure);
        //listIsometric.transform.GetChild(figureValue).gameObject.SetActive(false);
        //listViews.transform.GetChild(figureValue).gameObject.SetActive(false);
        figureValue++;

    }
    public void checkPlant()
    {
        if (answer == 1)
        {
            correct = true;
            deleteFigures(figureValue);
            activateFigures(figureValue);
            Debug.Log("Correcto");
        }
        else
        {
            correct = false;
            countdown.minusTimer();
            Debug.Log("Incorrecto");
        }
    }
    public void checkElevation()
    {
        if (answer == 0)
        {
            correct = true;
            deleteFigures(figureValue);
            activateFigures(figureValue);
            Debug.Log("Correcto");

        }
        else
        {
            correct = false;
            Debug.Log("Incorrecto");
            countdown.minusTimer();
        }
       
    }
    public void checkProfile()
    {
        if (answer == 2)
        {
            correct = true;
            deleteFigures(figureValue);
            activateFigures(figureValue);
            Debug.Log("Correcto");
        }
        else
        {
            correct = false;
            Debug.Log("Incorrecto");
            countdown.minusTimer();
        }
    }

}
