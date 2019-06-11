using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject tool;
    public GameObject Cable1;
    public GameObject Cable2;
    public bool on;
    private GameObject input;

    [SerializeField]
    private OnOff interaction;
    [SerializeField]
    private CheckPoint CheckPoint;// Класс оценки действий игрока

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
            if ((Cable1.GetComponent<Cable>().type == "line" || Cable1.GetComponent<Cable>().type == "null ") && Cable2.GetComponent<Cable>().type == "")
            {
                if (input == Cable2)
                {
                    Cable1.GetComponent<Cable>().type = Cable2.GetComponent<Cable>().type;
                    Cable1.GetComponent<Cable>().group = Cable2.GetComponent<Cable>().group;
                    Cable1.GetComponent<Cable>().U = Cable2.GetComponent<Cable>().U;
                }
                else
                {
                    input = Cable1;
                    Cable2.GetComponent<Cable>().type = Cable1.GetComponent<Cable>().type;
                    Cable2.GetComponent<Cable>().group = Cable1.GetComponent<Cable>().group;
                    Cable2.GetComponent<Cable>().U = Cable1.GetComponent<Cable>().U;
                }
            }
            else if ((Cable2.GetComponent<Cable>().type == "line" || Cable2.GetComponent<Cable>().type == "null ") && Cable1.GetComponent<Cable>().type == "")
            {
                if (input == Cable1)
                {
                    Cable2.GetComponent<Cable>().type = Cable1.GetComponent<Cable>().type;
                    Cable2.GetComponent<Cable>().group = Cable1.GetComponent<Cable>().group;
                    Cable2.GetComponent<Cable>().U = Cable1.GetComponent<Cable>().U;
                }
                else
                {
                    input = Cable2;
                    Cable1.GetComponent<Cable>().type = Cable2.GetComponent<Cable>().type;
                    Cable1.GetComponent<Cable>().group = Cable2.GetComponent<Cable>().group;
                    Cable1.GetComponent<Cable>().U = Cable2.GetComponent<Cable>().U;
                }
            }
            else if (Cable2.GetComponent<Cable>().type == "line" && Cable1.GetComponent<Cable>().type == "line")
            {
                if (input == Cable1)
                {
                    Cable2.GetComponent<Cable>().U = Cable1.GetComponent<Cable>().U;
                }
                else if (input == Cable2)
                {
                    Cable1.GetComponent<Cable>().U = Cable2.GetComponent<Cable>().U;
                }
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
            else
            {
                Cable1.GetComponent<Cable>().U = 0;
                Cable2.GetComponent<Cable>().U = 0;
            }
        }
    }
    void OnMouseDown()
    {
        bool onBefor = on;

        interaction.press(gameObject);

        if (onBefor != on)
        {
            CheckPoint.NullCheckU();
        }
        Debug.Log("notOffU = " + CheckPoint.notOffU);
        Debug.Log("notCheckU = " + CheckPoint.notCheckU);
    }
}
