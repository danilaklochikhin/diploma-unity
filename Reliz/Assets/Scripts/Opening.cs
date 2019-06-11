using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour
{
    public float U; //Напряжение в отверстие розетки
    public GameObject tool;

    [SerializeField]
    private Indication interaction;
    [SerializeField]
    private CheckPoint checkPoint;

    // Start is called before the first frame update
    void Start()
    {
        interaction.initializ(tool, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Кнопка мыши нажата
    void OnMouseDrag()
    {
        interaction.Display(U);
        checkPoint.notCheckU = false;
    }

    // Кнопка мыши отпущена
    void OnMouseUp()
    {
        interaction.Display(0);
    }
}
