using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour
{
    public GameObject Cable1;
    public GameObject Cable2;
    public bool screwed1 = true;
    public bool screwed2 = true;
    private Cable cable1;
    private Cable cable2;

    // Start is called before the first frame update
    void Start()
    {
        if (Cable1 != null)
            cable1 = Cable1.GetComponent<Cable>();
        if (Cable2 != null)
            cable2 = Cable2.GetComponent<Cable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (screwed1 && screwed2)
        {
            if (cable1.type == "line")
            {
                Cable2.GetComponent<Cable>().type = "line";
                Cable2.GetComponent<Cable>().group = cable1.group;
                Cable2.GetComponent<Cable>().U = cable1.U;
            }
            else if (cable2.type == "line")
            {
                Cable1.GetComponent<Cable>().type = "line";
                Cable1.GetComponent<Cable>().group = cable2.group;
                Cable1.GetComponent<Cable>().U = cable2.U;
            }
            else if (cable1.type == "null")
            {
                Cable2.GetComponent<Cable>().type = "null";
                Cable2.GetComponent<Cable>().group = cable1.group;
            }
            else if (cable2.type == "null")
            {
                Cable1.GetComponent<Cable>().type = "null";
                Cable1.GetComponent<Cable>().group = cable2.group;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Cable1 == null)
        {
            Cable1 = other.gameObject;
            cable1 = Cable1.GetComponent<Cable>();
        }
        else if (Cable2 == null)
        {
            Cable2 = other.gameObject;
            cable2 = Cable2.GetComponent<Cable>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (Cable1 == other.gameObject)
        {
            Cable1 = null;
            cable1 = null;
        }
        else if (Cable2 == other.gameObject)
        {
            Cable2 = null;
            cable2 = null;
        }
    }
}
