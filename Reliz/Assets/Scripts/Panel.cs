using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public Tool tool;
    //public int index; //индекс инструмента 

    [SerializeField]
    private Tools tools;
    // Start is called before the first frame update
    void Start()
    {
        tools.initializ(gameObject);
        tools.DrawPanel();

        if (gameObject.name == "Hand")
        {
            tool.name = tools.name; ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        tool.name = tools.name;
    }
}
