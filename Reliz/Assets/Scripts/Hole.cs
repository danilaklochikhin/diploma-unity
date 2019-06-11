using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject socket;
    public GameObject L, N;
    public GameObject tool;

    [SerializeField]
    private ScrewUnScrew interectionSUS;
    [SerializeField]
    private CheckPoint checkPoint;

    void Update()
    {
        // Передача параметра напряжения в класс оценки действий 
        if (L.GetComponent<Cable>().type == "line")
        {
            checkPoint.InputU = L.GetComponent<Cable>().U;
        }
        else if (N.GetComponent<Cable>().type == "line")
        {
            checkPoint.InputU = N.GetComponent<Cable>().U;
        }
        else
        {
            checkPoint.InputU = 0;
        }
    }
    
    void OnMouseDown()
    {
        bool visible = gameObject.activeInHierarchy;
        interectionSUS.screw(socket);
        if (visible != gameObject.activeInHierarchy)
            checkPoint.CheckInteraction(tool.GetComponent<Tool>().name);
    }
}
