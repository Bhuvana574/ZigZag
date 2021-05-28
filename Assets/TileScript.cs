using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{

   

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {  if (other.tag == "Player")
        {
            for (int i = 0; i < 1; i++)
            {
                TileManager.Instance.SpawnTile();
                Debug.Log("Spawn TILE");
            }
        }
    }
}