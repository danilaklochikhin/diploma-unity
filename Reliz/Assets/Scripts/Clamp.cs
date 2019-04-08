using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour
{
    public GameObject Cable1 = null;
    public GameObject Cable2 = null;
    public GameObject clam1, clam2;
    private Cable cable1;
    private Cable cable2;
    private GameObject input = null;

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
        if (clam1.GetComponent<Clam>().screwed && clam2.GetComponent<Clam>().screwed)
        {
            if (cable1.type != "" && input == null)
            {
                input = Cable1;
                initCab(Cable1, Cable2);
            }
            else if (cable2.type != "" && input == null)
            {
                input = Cable2;
                initCab(Cable2, Cable1);
            }
            else if (input == Cable2)
            {
                initCab(Cable2, Cable1);
            }
            else if (input == Cable1)
            {
                initCab(Cable1, Cable2);
            }
        }
        else if (clam1.GetComponent<Clam>().screwed && input == Cable1)
        {
            nullCab(Cable1);
        }
        else if (clam1.GetComponent<Clam>().screwed && input == Cable2)
        {
            nullCab(Cable2);
        }
        else if (clam2.GetComponent<Clam>().screwed && input == Cable1)
        {
            nullCab(Cable2);
        }
        else if (clam2.GetComponent<Clam>().screwed && input == Cable2)
        {
            nullCab(Cable1);
        }
    }

    void initCab(GameObject input, GameObject output)
    {
        output.GetComponent<Cable>().type = input.GetComponent<Cable>().type;
        output.GetComponent<Cable>().group = input.GetComponent<Cable>().group;
        output.GetComponent<Cable>().U = input.GetComponent<Cable>().U;
    }

    void nullCab(GameObject cab)
    {
        cab.GetComponent<Cable>().type = "";
        cab.GetComponent<Cable>().group = 0;
        cab.GetComponent<Cable>().U = 0;
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
            if (input == Cable1)
            {
                input = null;
                nullCab(Cable2);
            }
            Cable1 = null;
            cable1 = null;
        }
        else if (Cable2 == other.gameObject)
        {
            if (input == Cable2)
            {
                input = null;
                nullCab(Cable1);
            }
            Cable2 = null;
            cable2 = null;
        }
    }
}
