using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cap : MonoBehaviour
{
    public GameObject lamp, L, N;
    public GameObject tool;

    [SerializeField]
    private ScrewUnScrew interactionSUS;// Взаимодействие, отвечающее за закручивание лампочки в цоколь
    [SerializeField]
    private CheckPoint CheckPoint;// Класс оценки действий игрока

    // Start is called before the first frame update
    void Start()
    {
        CheckPoint.InputU = L.GetComponent<Cable>().U;
    }

    // Update is called once per frame
    void Update()
    {
        // Передача параметра напряжения в класс оценки действий 
        if (L.GetComponent<Cable>().type == "line")
        {
            CheckPoint.InputU = L.GetComponent<Cable>().U;
        }
        else if (N.GetComponent<Cable>().type == "line")
        {
            CheckPoint.InputU = N.GetComponent<Cable>().U;
        }
        else
        {
            CheckPoint.InputU = 0;
        }
    }

    void OnMouseDown()
    {
        CheckPoint.CheckInteraction(tool.GetComponent<Tool>().name);
        interactionSUS.screw(lamp);
    }
}
