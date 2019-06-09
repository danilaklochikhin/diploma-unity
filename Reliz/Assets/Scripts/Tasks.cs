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
    public bool done = false;// Переменная хранящая параметр выполнения данной задачи

    [SerializeField]
    public CheckPoint checkPoint;// Алгоритм оценки, относящийся к target

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
