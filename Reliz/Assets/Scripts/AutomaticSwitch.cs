using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticSwitch : MonoBehaviour
{
    public GameObject tool;
    public GameObject Cable;
    public float U;
    public int group;
    public bool on;

    [SerializeField]
    private OnOffAutomat interaction;
    // Start is called before the first frame update
    void Start()
    {
        interaction.initializ(tool, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            Cable.GetComponent<Cable>().type = "line";
            Cable.GetComponent<Cable>().group = group;
            Cable.GetComponent<Cable>().U = U;
        }
        else
        {
            Cable.GetComponent<Cable>().type = "line";
            Cable.GetComponent<Cable>().group = group;
            Cable.GetComponent<Cable>().U = 0;
        }
    }

    void OnMouseDown()
    {
        interaction.press();
    }
}
