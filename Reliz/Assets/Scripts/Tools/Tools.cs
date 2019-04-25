using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "new Tool")]
public class Tools : ScriptableObject
{
    public string name; //Наименование  инструмента 
    public Sprite image; //Отображение на панели интрументов
    public GameObject panel; //Панель, на которой расположен инструмент
    public GameObject toolVisual, clone; //Визуализированный инструмент и его клон
    public Vector3 startPosition; // Стартовая позиция инструмента на сцене
    //public Color color;

    public void initializ(GameObject go, GameObject parent)
    {
        panel = go;
        DrawPanel();
        //startPosition = toolVisual.transform.position;
        clone = Instantiate(toolVisual, parent.transform);
        //startPosition.SetPositionAndRotation (new Vector3(clone.transform.localPosition.x,clone.transform.localPosition.y, clone.transform.localPosition.z),clone.transform.localRotation);
        clone.SetActive(false);
    }


    public void DrawPanel()
    {
        panel.GetComponent<Image>().sprite = image;
    }

    // Отрисовка выбранного инструмента
    public void DrawTool()
    {
        // Возвращаем в стартовую позицию
        //clone.transform.position = startPosition;

        // Передаем визуализацию в инструмент
        panel.GetComponent<Panel>().tool.GetComponent<Tool>().newTool(clone);
    }
}

