using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/ScrewUnScrew")]
public class ScrewUnScrew : Interactions
{
    public override void initializ(GameObject objTool, GameObject objTarget)
    {
        tool = objTool;
        target = objTarget;
    }

    // Функция обработки действия пользователя по закручиванию/откручиванию объектов
    // Входящие переменные:
    // go - объект над которым производят действия
    // Возвращает 1 если взаимодействие выполнено, 0 - если не выполнено
    public void screw(GameObject go)
    {
        target = go;

        if (tool.GetComponent<Tool>().name == "screwdriver")// Если инструмент отвертка
        {
            if (target.tag == "clam")// Если объект клемма
            {
                if (target.GetComponent<Clam>().screwed)
                {
                    target.GetComponent<Clam>().screwed = false;
                }
                else target.GetComponent<Clam>().screwed = true;
            }
        }
        else if (tool.GetComponent<Tool>().name == "hand" || tool.GetComponent<Tool>().name == "gloves")// Если инструмент рука или перчатки
        {
            if (target.tag == "lamp")// Если объект лампочка
            {
                if (target.activeInHierarchy)// Если объект активен на сцене
                {
                    target.SetActive(false);
                }
                else 
                {
                    target.SetActive(true);
                }
            }
        }
    }
}
