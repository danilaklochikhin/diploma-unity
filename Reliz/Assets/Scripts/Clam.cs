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
        interaction.screw(gameObject);
    }

    // Кнопка мыши нажата
    void OnMouseDrag()
    {
        interaction1.Display(U);
    }

    // Кнопка мыши отпущена
    void OnMouseUp()
    {
        interaction1.Display(0);
    }
}
