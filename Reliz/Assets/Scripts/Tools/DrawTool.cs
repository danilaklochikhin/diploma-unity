using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawTool : MonoBehaviour
{
    public Sprite image; //Отображение на панели интрументов
    public GameObject panel; //Панель, на которой расположен инструмент

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("dt");
        panel.GetComponent<Image>().sprite = image;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
