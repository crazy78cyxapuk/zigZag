using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapGeneration : MonoBehaviour
{
    //создание платформ, кристаллов

    public GameObject platTop, platRight; //платформы, по которым движется игрок
    public GameObject crystal; //кристалл для получения очков
    public GameObject currentTile; //для создания платформ
    private int countTileCreate; //счетчик для создания платформ
    private int countTileDeleted; //счетчик для удаления платформ
    public static bool deletedBool = false;

    void Start()
    {
        deletedBool = false;
        countTileCreate = 0;
        countTileDeleted = 1;
        for(int i = 0; i < 50; i++) //создаем первоначальные платформы
        {
            createPlatform();
        }
        
    }
    
    private void createPlatform() //создание платформ
    {
        int rand = Random.Range(0, 2);
        if (rand == 0) //создаем платформы с рандомным направлением
        {
            currentTile = Instantiate(platTop, currentTile.transform.GetChild(0).position, Quaternion.identity); //создаем переднюю платформу
            countTileCreate++;
            currentTile.name = countTileCreate.ToString(); 
        } else
        {
            currentTile = Instantiate(platRight, currentTile.transform.GetChild(0).position, Quaternion.identity); //создаем правую платформу
            countTileCreate++;
            currentTile.name = countTileCreate.ToString();
        }

        //создаем кристалл, с вероятностью в 20%
        rand = Random.Range(0, 101);
        if (rand < 21)
        {
            Instantiate(crystal, currentTile.transform.GetChild(1).position, Quaternion.identity);
        }
    }

    private void deletedTile() //удаление платформ
    {
        GameObject deletedObj = GameObject.Find(countTileDeleted.ToString());
        Destroy(deletedObj);
        countTileDeleted++;        
    }

    private void Update()
    {
        if (deletedBool) //обработчик для удаления и для создания платформ
        {
            deletedTile();
            createPlatform();
            deletedBool = false;
        }
    }
}
