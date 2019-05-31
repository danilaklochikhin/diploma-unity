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
    public TascList[] tascs; // Задания, необходимые к выполнению
    public TascList[] securityRegulations; // Правила безопасности, которые необходимо выполнить
    public Sprite imageBackground; // Визуализация наряд-допуска
    public int[][] sequenceTasc; // Допустимые последовательности выполнения заданий
}

public class TascList
{
    public string name; // Задание, необходимое к выполнению
    public bool done; // Флаг выполнения задания
    public int numberSequence; // Порядковый номер в последовательности выполненых заданий
}