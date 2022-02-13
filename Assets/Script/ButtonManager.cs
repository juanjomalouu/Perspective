using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager: MonoBehaviour
{
    public GameObject image;
    public void Start()
    {
        image.SetActive(false);
    }
    public void OnMouseOver()
    {
        image.SetActive(true);
    }

    public void OnMouseExit()
    {
        image.SetActive(false);
    }
}
