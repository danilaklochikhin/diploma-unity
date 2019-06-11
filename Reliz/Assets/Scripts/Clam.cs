using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clam : MonoBehaviour
{
    public bool screwed;
    public Color color = Color.yellow;
    public GameObject tool;
    public float U;

    [SerializeField]
    private ScrewUnScrew interaction;
    [SerializeField]
    private Indication interaction1;
    [SerializeField]
    private CheckPoint CheckPoint;// Класс оценки действий игрока

    // Start is called before the first frame update
    void Start()
    {
        interaction.initializ(tool, gameObject);
        interaction1.initializ(tool, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        bool screwedBefor = screwed;
        interaction.screw(gameObject);
        if (screwedBefor != screwed)
        {
            if (screwed)
            CheckPoint.NullNotOffU();
            else CheckPoint.notOffU = false;
            Debug.Log("notOffU = " + CheckPoint.notOffU);
            Debug.Log("notCheckU = " + CheckPoint.notCheckU);
        }
    }

    // Кнопка мыши нажата
    void OnMouseDrag()
    {
        if (interaction1.Display(U))
        {
            CheckPoint.notCheckU = false;
            Debug.Log("notCheckU = " + CheckPoint.notCheckU);
        }
    }

    // Кнопка мыши отпущена
    void OnMouseUp()
    {
        interaction1.Display(0);
    }
}
