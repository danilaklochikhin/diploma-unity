using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticSwitch : MonoBehaviour
{
    public GameObject tool;
    public GameObject Cable; // Отходящий провод
    public GameObject Ind; // Инидикация состояния (Вкл/выкл)
    public float U;
    public int group;
    public bool on;

    [SerializeField]
    private OnOff interaction;
    
    void Start()
    {
        interaction.initializ(tool, gameObject);
        if (on)
        {
            Renderer rend = Ind.GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_SpecColor", Color.green);
        }
        else
        {
            Renderer rend = Ind.GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_SpecColor", Color.red);
        }
    }

    
    void Update()
    {
        // Инициализация отходящего провода
        if (on && Cable != null)
        {
            Cable.GetComponent<Cable>().type = "line";
            Cable.GetComponent<Cable>().group = group;
            Cable.GetComponent<Cable>().U = U;
        }
        else if (Cable != null)
        {
            Cable.GetComponent<Cable>().type = "line";
            Cable.GetComponent<Cable>().group = group;
            Cable.GetComponent<Cable>().U = 0;
        }

        // Отрисовка индикации состояния
        if (on)
        {
            Renderer rend = Ind.GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_SpecColor", Color.green);
        }
        else
        {
            Renderer rend = Ind.GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_SpecColor", Color.red);
        }
    }

    void OnMouseDown()
    {
        interaction.press(gameObject);
    }
}
