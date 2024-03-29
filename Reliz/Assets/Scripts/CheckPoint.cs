﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "new CheckPoint")]
public class CheckPoint : ScriptableObject
{
    public bool notCheckU = true; // Переменная, говорящая что пользователь не проверил наличие напряжение
    public bool notOffU = true; // Переменная, говорящая что пользователь не отключил подачу тока
    public bool workOnU = false;// Работа под напряжением
    public bool useGloves = false;// ИСпользование перчаток
    public int Score; // Колиичество баллов, набранных в момент выполнения действия
    public float InputU; // Значение приходящего напряжения
    public int humidity; // Значение влажности в комнате в %

    // Функция обнуления выполненых ранее отключений подачи U
    public void NullNotOffU()
    {
        notCheckU = true;

        if (InputU != 0)
        {
            notOffU = true;
            Debug.Log("notOffU = " + notOffU);
        }
        Debug.Log("notOffU = " + notOffU);
        Score = 0;
    }

    // Функция обнуления ранее сделанных проверок U
    public void NullCheckU()
    {
        notCheckU = true;
        Debug.Log("notCheckU = " + notCheckU);
        Score = 0;
    }

    // Функция проверки действия игрока
    // Входные переменные:
    // nameTool - название инструмента, которым было совершено действие
    public void CheckInteraction(string nameTool)
    {
        // Алгоритм оценивания действий игрока
        if (InputU == 0) // Нет напряжения
        {
            workOnU = false;
            useGloves = false;
            
            if (notOffU)// Не отключил подачу тока
            {
                if (notCheckU)// Не проверил наличие напряжения
                {
                    Score = 0; // Присвоить низкий балл 
                }
                else
                {
                    Score = 1; // Присвоить средний балл
                }
            }
            else 
            {
                if (notCheckU)// Не проверил наличие напряжения
                {
                    Score = 1;
                }
                else
                {
                    Score = 2;// Присвоить высокий балл
                }
            }
        }
        else
        {
            if (nameTool == "gloves")
            {
                workOnU = true;
                useGloves = true;
                Score = 1;
            }
            else
            {
                workOnU = true;
                if (humidity < 70)
                {
                    Score = 0;
                }
                else 
                {
                    Score = -1;
                }
            }
        }
        Debug.Log("Score = "+Score);
   }

    public void nullCP()
    {
        notCheckU = true; 
        notOffU = true; 
        workOnU = false;
        useGloves = false;
        Score = 0; 
    }
}
