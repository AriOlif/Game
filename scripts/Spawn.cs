using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float spawnRangeX= 10;
    public GameObject trash;
    private float washUpTime = 1.0f;

    //private float shipSpawnRangeX= -71;
    //public GameObject boat;
    //private float shipSpawnTime = 7.5f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemyspawn());
        //StartCoroutine(Shipspawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    IEnumerator Enemyspawn()
    {
        
	    while(true)
        {
            float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
		    float spawnPosY = Random.Range(-2.1f, 4.2f);
		    Vector2 trashSpawn = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY);
		    Instantiate(trash, trashSpawn, Quaternion.identity);
		    yield return new WaitForSeconds(washUpTime);
        }
    
}  

    /*IEnumerator Shipspawn()
    {   
        
	        while(true)
            {
	            float shipSpawnPosX = shipSpawnRangeX;
		        float shipSpawnPosY = Random.Range(35.0f,  27.0f);
		        Vector2 shipSpawn = new Vector2(shipSpawnRangeX, shipSpawnPosY);
		        Instantiate(boat, shipSpawn, Quaternion.identity);
		        yield return new WaitForSeconds(shipSpawnTime);
            }
        
    }*/




}
