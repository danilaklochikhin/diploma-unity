using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssessmemtSistem : MonoBehaviour
{
    public GameObject UIPanel; // Объект в котором распологаются компоненты для вывода результата теста
    public GameObject ResultText; // Текст об успешном/неуспешном прохождении теста
    public GameObject ResultTasks; // Текст о выполненым/невыполненым элементом задачи теста
    public GameObject ResultSecurityR;// Текст о выполненым/невыполненым правиле технике безопасности
    public GameObject Score; // Текст с набарнным количеством баллов
    public GameObject background;
    public GameObject button, button1;

    [HideInInspector]
    public int TotalScore = 0;// Общее количество баллов, набранное пользователем в тесте
    [HideInInspector]
    public int maxScore = 0;// Максимальновозможное количество баллов за тест
    [HideInInspector]
    public bool testDone = true;// Параметр выполнения всех подзадач в тесте 
    [HideInInspector]
    public bool end = false;

    [SerializeField]
    private Tasks tasks;// Список всех подзаздач в тесте
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Отслеживаем выполнения пользователем элементов задачи
        foreach (Task task in tasks.item)
        {
            // Проверка выполнения подзадачи
            if (!task.target.activeInHierarchy)// Если объект не активен (Откручен)
            {
                task.done = 0.5f;
            }
            else if (task.target.activeInHierarchy && (task.done == 0.5f))// Если объект ранее был не активен (Произведена замена)
            {
                task.done = 1;
            }

            // Проверка на допущенные ошибки
            if (task.checkPoint.Score == -1 && !end) // Допущена критическая ошибка
            {
                EndTest("end test");
                end = true;
            }
            else if (task.done == 1)// Есть выполненый элемент задачи
            {
                TotalScore += task.checkPoint.Score;
                task.done = -1; // Отработанная и оцененная задача
            }
            else if (task.done < 1 && task.done > 0)// Есть невыполненый элемент задачи
            {
                testDone = false;
            }
        }

        if (testDone)
        {
            EndTest("Done test");
        }
    }

    public void EndTest(string nameDone)
    {
        // Отключаем панель инструментов
        Panel[] offPanels = UIPanel.GetComponentsInChildren<Panel>();
        foreach (Panel op in offPanels)
        {
            op.activeOff();
        }
        // Включаем текст о результатах теста
        ResultText.SetActive(true);
        ResultTasks.SetActive(true);
        ResultSecurityR.SetActive(true);
        Score.SetActive(true);
        background.SetActive(true);
        button.SetActive(true);
        button1.SetActive(true);

        if (nameDone == "Done test")
        {
            ResultText.GetComponent<Text>().text = "Тест пройден успешно !";
            ResultText.GetComponent<Text>().color = Color.blue;

            // Вывод выпольненых элементо задачи
            foreach (Task task in tasks.item)
            {
                maxScore += 3;// Максимальное количество баллов за выполнение одного элемента заданаия 

                done(task);
            }
            Score.GetComponent<Text>().text += " "+(100*TotalScore/maxScore)+"%";
        }
        else if (nameDone == "end test")
        {
            ResultText.GetComponent<Text>().text = "Тест не пройден !";
            ResultText.GetComponent<Text>().color = Color.red;

            // Вывод выпольненых элементо задачи
            foreach (Task task in tasks.item)
            {
                maxScore += 3;// Максимальное количество баллов за выполнение одного элемента заданаия 

                if (task.done > 0 && task.done < 1)
                {
                    ResultTasks.GetComponent<Text>().text += task.Description + " - не выполнено\n";
                }
                else
                {
                    done(task);
                }               
            }
            Score.GetComponent<Text>().text += " "+(100*TotalScore/maxScore)+"%";
        }
    }

    public void done(Task t)
    {
        ResultTasks.GetComponent<Text>().text += t.Description + " - выполнено\n";
        ResultSecurityR.GetComponent<Text>().text += t.Description + ": \n";

        if (t.checkPoint.workOnU)
        {
            ResultSecurityR.GetComponent<Text>().text += "Не отключено напряжение !\n";
            ResultSecurityR.GetComponent<Text>().text += "Работа в диэлектрических перчатках - ";
            if (t.checkPoint.useGloves)
            {
                ResultSecurityR.GetComponent<Text>().text += "выполнено !\n";
            }
            else ResultSecurityR.GetComponent<Text>().text += "не выполнено !\n";
        }
        if (t.checkPoint.notOffU)
        {
            ResultSecurityR.GetComponent<Text>().text += "Отключение токоведущих частей - не выполнено !\n";
        }
        else ResultSecurityR.GetComponent<Text>().text += "Отключение токоведущих частей - выполнено !\n";

        ResultSecurityR.GetComponent<Text>().text += "Проверка напряжения в сети - ";
        if (t.checkPoint.notCheckU)
        {
            ResultSecurityR.GetComponent<Text>().text += "не выполнено !\n";
        }
        else ResultSecurityR.GetComponent<Text>().text += "выполнено !\n";

        ResultSecurityR.GetComponent<Text>().text += "\n";
    }
}
