using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
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
