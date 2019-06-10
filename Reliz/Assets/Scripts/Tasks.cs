using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "new Tasks")]
public class Tasks : ScriptableObject
{
    public Task[] item; // Список тестов
}

[System.Serializable]
public class Task
{
    public string Description; // Описание элемента задачи, требущего выполнения пользователем
    public GameObject target;// Объект, над кооторым требуется произвести действия
    public float done = 0;// Переменная хранящая % выполнения данной задачи (1 - 100%, 0.5 - 50%)

    [SerializeField]
    public CheckPoint checkPoint;// Алгоритм оценки, относящийся к target
}
