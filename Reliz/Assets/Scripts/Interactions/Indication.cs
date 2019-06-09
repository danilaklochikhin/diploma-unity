using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Interactions/Indication")]
public class Indication : Interactions
{
    // Функция инициализации
    public override void initializ(GameObject objTool, GameObject objTarget)
    {
        tool = objTool;
        target = objTarget;
    }
    // Функция индикации
    // Входные параметры: U - напряжение участка, который проверяем
    // Возвращает 1 - если функция выполнилась, 0 - если нет
    public bool Display(float U)
    {
        if (tool.GetComponent<Tool>().name == "Indicator")
        {
            if (U > 0)
                tool.GetComponent<Tool>().tool.GetComponent<Light>().enabled = true;
            else
                tool.GetComponent<Tool>().tool.GetComponent<Light>().enabled = false;

            return true;
        }
        return false;
    }
}
