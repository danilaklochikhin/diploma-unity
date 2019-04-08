using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clam : MonoBehaviour
{
    public bool screwed;
    public Color color = Color.yellow;
    public GameObject tool;

    [SerializeField]
    private ScrewUnScrew interaction;
    // Start is called before the first frame update
    void Start()
    {
        interaction.initializ(tool, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        interaction.screw();
    }
}
