using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpForDeletedTiles : MonoBehaviour
{
    private int countTiles = 0;

    private void Start()
    { 
        //a = deleted.deletedBool;
        //print(a);
        //print(deleted.deletedBool);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tile")
        {
            countTiles++;
            if (countTiles > 5)
            {
                mapGeneration.deletedBool = true;
            }
        }
    }
}
