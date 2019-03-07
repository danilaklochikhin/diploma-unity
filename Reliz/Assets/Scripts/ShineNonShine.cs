using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShineNonShine : MonoBehaviour
{
    public GameObject L;
    public GameObject N;
    public GameObject lamp;
    public GameObject cap;
    private bool fused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fused = lamp.GetComponent<Lamp>().fused;

        if (fused)
           lamp.GetComponent<Light>().enabled = false;
        else if (cap.GetComponent<Cap>().connection)
        {
            if (L.GetComponent<Cable>().type == "line" && L.GetComponent<Cable>().U == 220 && N.GetComponent<Cable>().type == "null" && L.GetComponent<Cable>().group == N.GetComponent<Cable>().group)
                lamp.GetComponent<Light>().enabled = true;
            else if (L.GetComponent<Cable>().type == "null" && N.GetComponent<Cable>().U == 220 && N.GetComponent<Cable>().type == "line" && L.GetComponent<Cable>().group == N.GetComponent<Cable>().group)
                lamp.GetComponent<Light>().enabled = true;
            else lamp.GetComponent<Light>().enabled = false;
        }
        else lamp.GetComponent<Light>().enabled = false;
    }
}
