using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public string name;
    public GameObject tool;// Визуализированный инструмент

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Функция замены визуализации инструмента
    // Входные переменные: новый объект визуализации
    public void newTool(GameObject nTool)
    {
        if (tool != null)
            tool.SetActive(false);// Отключаем старую визуализацию

        tool = nTool;// Присваем новую визуализацию
        tool.SetActive(true);// Включаем новую визуализацию
    }

    //void Press()
    //{
    //    tool.name = tools.name;
    //    tools.DrawTool();
    //}
    
}
