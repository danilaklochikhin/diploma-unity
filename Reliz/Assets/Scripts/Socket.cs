﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    public GameObject L, N;// Приходящие провода
    public GameObject OpeningL, OpeningN;// Отверстия в розетке
    public int IP;
    public bool fused;

    [SerializeField]
    private Tasks tasks;// Cписок всех подзадач теста
    // Start is called before the first frame update
    void Start()
    {
        tasks.item[1].target = gameObject;
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
    }
}
