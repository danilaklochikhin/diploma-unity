using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffSwitch : MonoBehaviour
{
    public GameObject tool;
    public GameObject Cable1;
    public GameObject Cable2;
    public bool on;
    private GameObject input;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
            if (on)
            {
                if (Cable1.GetComponent<Cable>().type == "line" && Cable2.GetComponent<Cable>().type == "")
                {
                    input = Cable1;
                    Cable2.GetComponent<Cable>().type = "line";
                    Cable2.GetComponent<Cable>().group = Cable1.GetComponent<Cable>().group;
                    Cable2.GetComponent<Cable>().U = Cable1.GetComponent<Cable>().U;
                    Debug.Log("if");
                }
                else if (Cable2.GetComponent<Cable>().type == "line" && Cable1.GetComponent<Cable>().type == "")
                {
                    input = Cable2;
                    Cable1.GetComponent<Cable>().type = "line";
                    Cable1.GetComponent<Cable>().group = Cable2.GetComponent<Cable>().group;
                    Cable1.GetComponent<Cable>().U = Cable2.GetComponent<Cable>().U;
                }
                else if (Cable2.GetComponent<Cable>().type == "line" && Cable1.GetComponent<Cable>().type == "")
                {
                    input = Cable2;
                    Cable1.GetComponent<Cable>().type = "line";
                    Cable1.GetComponent<Cable>().group = Cable2.GetComponent<Cable>().group;
                    Cable1.GetComponent<Cable>().U = Cable2.GetComponent<Cable>().U;
                }
                else if (Cable2.GetComponent<Cable>().type == "line" && Cable1.GetComponent<Cable>().type == "line")
                {
                    if (input == Cable1)
                        Cable2.GetComponent<Cable>().U = Cable1.GetComponent<Cable>().U;
                    else if (input == Cable2)
                        Cable1.GetComponent<Cable>().U = Cable2.GetComponent<Cable>().U;
                }
            }
            else
            {
                if (input == Cable1)
                {
                    Cable2.GetComponent<Cable>().U = 0;
                }
                else if (input == Cable2)
                {
                    Cable1.GetComponent<Cable>().U = 0;
                }
            }
    }

    void OnMouseDown()
    {
       if (tool.GetComponent<Tool>().name == "hand")
       {
           if (on)
               on = false;
           else
               on = true;
       }
    }
}