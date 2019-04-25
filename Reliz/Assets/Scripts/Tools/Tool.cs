using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tool : MonoBehaviour
{
    public string name;
    public GameObject tool;// Визуализированный инструмент
    public GameObject activePanel;// Активная панель инструментов

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
    public void newTool(GameObject nTool, GameObject nPanel)
    {
        // Зарисовка панели инструментов
        ColorBlock newColorButton = activePanel.GetComponent<Button>().colors;
        newColorButton.normalColor = Color.white;
        activePanel.GetComponent<Button>().colors = newColorButton; // Возвращаем зарисовку старой панели в стартовое положение
        activePanel = nPanel; // Присваеваем новую панель
        newColorButton.normalColor = Color.grey;
        activePanel.GetComponent<Button>().colors = newColorButton; // Зарисовываем активную панель

        // Смена визуализированного инструмента
        if (tool != null)
            tool.SetActive(false); // Отключаем старую визуализацию

        tool = nTool;// Присваем новую визуализацию
        tool.SetActive(true);// Включаем новую визуализацию
    }

    //void Press()
    //{
    //    tool.name = tools.name;
    //    tools.DrawTool();
    //}
    
}
