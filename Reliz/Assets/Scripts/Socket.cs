using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    public GameObject L, N;// Приходящие провода
    public GameObject OpeningL, OpeningN;// Отверстия в розетке
    public GameObject hole;
    public GameObject tool;
    public int IP;
    public bool fused;

    [SerializeField]
    private Tasks tasks;// Cписок всех подзадач теста
    [SerializeField]
    private CheckPoint checkPoint;// Cписок всех подзадач теста
    [SerializeField]
    private ScrewUnScrew interectionSUS;

    // Start is called before the first frame update
    void Start()
    {
        tasks.item[1].target = gameObject;
        tasks.item[1].done = 0f;
        checkPoint.nullCP();
        checkPoint.InputU = L.GetComponent<Cable>().U;
    }

    // Update is called once per frame
    void Update()
    {
        if (!fused)
        {
            OpeningL.GetComponent<Opening>().U = L.GetComponent<Cable>().U;
            OpeningN.GetComponent<Opening>().U = N.GetComponent<Cable>().U;
        }
        else
        {
            OpeningL.GetComponent<Opening>().U = 0;
            OpeningN.GetComponent<Opening>().U = 0;
        }

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
        interectionSUS.screw(gameObject);
        checkPoint.CheckInteraction(tool.GetComponent<Tool>().name);
    }
}
