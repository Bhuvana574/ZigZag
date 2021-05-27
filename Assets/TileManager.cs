using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject []tiles;
    public GameObject currentTile;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i= 0;i< 10;i++)
            {
            SpawnTile();
        }
      
       // Instantiate(leftTile, currentTile.transform.GetChild(0).GetChild(1).position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnTile() 
    {
        int index = Random.Range(0, tiles.Length);
       currentTile=(GameObject) Instantiate(tiles[index], currentTile.transform.GetChild(index).position, Quaternion.identity);
    }
}
