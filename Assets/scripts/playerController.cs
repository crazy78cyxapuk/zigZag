using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //управление игроком

    public const float speed = 5; //скорость игркока
    private Vector3 dir; //направление игрока

    void Start()
    {
        dir = Vector3.zero; //задаем нулевой вектор, чтобы игра началась с клика
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (dir==Vector3.forward) //меняем направление игрока в другую сторону
            {
                dir = Vector3.right; //направляем игрока направо
            }
            else
            {
                dir = Vector3.forward; //направляем игрока прямо
            }
        }

        transform.Translate(dir * speed * Time.deltaTime); //задаем скорость и направление игроку

    }
}
