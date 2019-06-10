using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssessmemtSistem : MonoBehaviour
{
    public int TotalScore = 0;// Общее количество баллов, набранное пользователем в тесте
    public bool testDone = true;// Параметр выполнения всех подзадач в тесте 

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
            if (task.checkPoint.Score == -1) // Допущена критическая ошибка
            {
                EndTest("Error security requlation");
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
        Debug.Log("End");
        if (nameDone == "Done test")
        {
            
            Debug.Log(TotalScore);
        }
        else if (nameDone == "end test")
        {
            foreach (Task task in tasks.item)
            {
                TotalScore += task.checkPoint.Score;
            }
            Debug.Log(TotalScore);
        }
    }
}
