using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName="new Test")]
// Класс, содержащий информацию по всем упражнениям тренажера
public class Tests : ScriptableObject
{
    public Test[] item; // Список тестов
}

[System.Serializable]
// Класс с информацией по одному тесту
public class Test
{
    public string Name; // Имя теста
    public string nameScene; // Имя сцены, котоую необходимо будет загрузить
}