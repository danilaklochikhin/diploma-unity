using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChoseTest : MonoBehaviour
{
    public int numberTest; // Номер теста по списку
    public string Description; // Описание теста

    [SerializeField]
    private Tests tests; // Список всех тестов
    
    // Start is called before the first frame update
    void Start()
    {
        Description = tests.item[numberTest].Name;
        gameObject.GetComponentInChildren<Text>().text = Description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Выбор упражнения - при выборе теста, переходим на сцену упражнения
    public void Chose()
    {
        // Загружаем сцену с тестом
        SceneManager.LoadScene(tests.item[numberTest].nameScene);
    }
}
