﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoseTool : MonoBehaviour
{
    public string name;
    public GameObject tool;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        tool.GetComponent<Tool>().name = name;
    }
}
