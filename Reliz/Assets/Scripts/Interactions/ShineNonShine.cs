using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/ShineNonShine")]
public class ShineNonShine : Interactions
{
    private bool fused;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    public void shine(GameObject L, GameObject N, GameObject cap)
    {
        fused = target.GetComponent<Lamp>().fused;

        if (fused)
            target.GetComponent<Light>().enabled = false;
        else if (cap.GetComponent<Cap>().connection)
        {
            if (L.GetComponent<Cable>().type == "line" && L.GetComponent<Cable>().U == 220 && N.GetComponent<Cable>().type == "null" && L.GetComponent<Cable>().group == N.GetComponent<Cable>().group)
                target.GetComponent<Light>().enabled = true;
            else if (L.GetComponent<Cable>().type == "null" && N.GetComponent<Cable>().U == 220 && N.GetComponent<Cable>().type == "line" && L.GetComponent<Cable>().group == N.GetComponent<Cable>().group)
                target.GetComponent<Light>().enabled = true;
            else target.GetComponent<Light>().enabled = false;
        }
        else target.GetComponent<Light>().enabled = false;
    }

    public override void initializ(GameObject objTool, GameObject objTarget)
    {
        target = objTarget;
    }
    
}
