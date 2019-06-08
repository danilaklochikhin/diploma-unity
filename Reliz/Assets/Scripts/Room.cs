using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public int humidity;// Влажность воздуха в комнате в %

    [SerializeField]
    private CheckPoint [] CheckPoints;
    // Start is called before the first frame update
    void Start()
    {
        foreach (CheckPoint CP in CheckPoints)
        {
            CP.humidity = humidity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
