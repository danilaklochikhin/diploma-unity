using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "new CheckPoint")]
public class CheckPoint : ScriptableObject
{
    public bool notCheckU; // Переменная, говорящая что пользователь не проверил наличие напряжение
    public bool notOffU; // Переменная, говорящая что пользователь не отключил подачу тока
    public int Score; // Колиичество баллов, набранных в момент выполнения действия
    public float InputU; // Значение приходящего напряжения
    public int humidity; // Значение влажности в комнате в %

    // Функция обнуления выполненых действий игрока
    // Входные параменты: type - тип по которому обнуляются показания(Обнуление по праверки наличия напряжения, обнуление по отключению подачи тока) 
    public void Null(string type)
    { 
        if (type == "Check U")
        {
            notCheckU = true;
            Score = 0;
        }
        else if (type == "Off U")
        {
            notOffU = true;
            Score = 0;
        }
    }

    // Функция проверки действия игрока
    // Входные переменные:
    // nameTool - название инструмента, которым было совершено действие
    public void CheckInteraction(string nameTool)
    {
        Debug.Log("U - " + InputU + "\n" + "Humidity - " + humidity);
        // Алгоритм оценивания действий игрока
        if (InputU == 0) // Нет напряжения
        {
            if (notOffU)// Не отключил подачу тока
            {
                if (notCheckU)// Не проверил наличие напряжения
                {
                    Score = 1; // Присвоить низкий балл 
                }
                else
                {
                    Score = 2; // Присвоить средний балл
                }
            }
            else 
            {
                if (notCheckU)// Не проверил наличие напряжения
                {
                    Score = 2;
                }
                else
                {
                    Score = 3;// Присвоить высокий балл
                }
            }
        }
        else
        {
            if (nameTool == "gloves")
            {
                Score = 2;
            }
            else
            {
                if (humidity < 70)
                {
                    Score = 1;
                }
                else 
                {
                    Debug.Log("EndTest");
                }
            }
        }
        Debug.Log(Score);
    }
}
