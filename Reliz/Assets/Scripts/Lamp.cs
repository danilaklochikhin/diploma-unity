using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject tool, cap; // Инструмент, выбранный пользователем, 
                                 // и цоколь, в который вкручена лампочка. 
    
    public bool connection = false;
    public bool fused;

    [SerializeField]
    private ShineNonShine interaction; // Взаимодействие, отвечающее за свечение лампочки
    [SerializeField]
    private ScrewUnScrew interactionSUS;// Взаимодействие, отвечающее за закручивание и откручивание лампочки от цоколя

    void Start()
    {
        // Инициализируем взаимодействие СветитьНеСветить
        interaction.initializ(tool, gameObject);
    }
    void Update()
    {
        // Вызываем функцию светить 
        // В качестве входных параметров передаем фазу и ноль с цоколя
        interaction.shine(cap.GetComponent<Cap>().L, cap.GetComponent<Cap>().N);
    }
    void OnTriggerStay(Collider otherObj)
    {
        if (otherObj.GetComponent<Cap>().lamp == gameObject)
        {
            connection = true;
        }
    }

    void OnTriggerExit(Collider otherObj)
    {
        if (otherObj.GetComponent<Cap>().lamp == gameObject)
        {
            connection = false;
        }
    }
    
}
