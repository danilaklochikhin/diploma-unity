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
        foreach (Task task in tasks.item)
        {
            if (task.checkPoint.Score == -1)
            {
                EndTest("Error security requlation");
            }
            else if (!task.done)
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
        if (nameDone == "Done test")
        {
            foreach (Task task in tasks.item)
            {
                TotalScore += task.checkPoint.Score;
            }
            Debug.Log(TotalScore);
        }
    }
}
