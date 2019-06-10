using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject tool;
    public GameObject parent;

    [SerializeField]
    private Tools tools;
    // Start is called before the first frame update
    void Start()
    {
        tools.initializ(gameObject, parent);

        if (gameObject.name == "Hand")
        {
            tool.GetComponent<Tool>().name = tools.name;
            tool.GetComponent<Tool>().tool = null;
            tools.DrawTool();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Функция выбора инструмента 
    public void Press()
    {
        tool.GetComponent<Tool>().name = tools.name;
        tools.DrawTool();
    }

    public void activeOff()
    {
        gameObject.SetActive(false);
    }
}
