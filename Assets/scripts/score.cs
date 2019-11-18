using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    //получение очков, когда собираем кристаллы

    private Text scoreText; //отображение на экране

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            scoreText = (Text)FindObjectOfType(typeof(Text)); //ищем текстовое поле на экране
            scoreText.text = (int.Parse(scoreText.text) + 1).ToString(); //преобразовываем текст в integer и увеличиваем счет на единицу; возвращаем полученное число очков
            Destroy(gameObject); //удаляем кристалл с карты
        }
    }
}
