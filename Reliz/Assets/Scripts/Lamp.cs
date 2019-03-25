using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject tool, L, N, cap;
    public bool fused;

    [SerializeField]
    private ShineNonShine interaction;

    void Start()
    {
        interaction.initializ(tool, gameObject);
    }
    void Update()
    {
        interaction.shine(L, N, cap);
    }
    //void initializ(Interactions i)
    //{
    //    interaction = i;
    //}
}
