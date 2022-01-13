using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;
	float randX;
	float randY;
	Vector2 whereToSpawn;
	

     public float delayAndSpawnRate = 2;
     public float timeUntilSpawnRateIncrease = 30;
    void Start()
     {
         StartCoroutine(SpawnObject(delayAndSpawnRate));
     }
 
     IEnumerator SpawnObject( float firstDelay )
     {
         float spawnRateCountdown = timeUntilSpawnRateIncrease ;
         float spawnCountdown = firstDelay ;
         while( true )
         {
             yield return null ;
             spawnRateCountdown -= Time.deltaTime;
             spawnCountdown     -= Time.deltaTime;
 
             // Should a new object be spawned?
             if( spawnCountdown < 0 )
             {
                 spawnCountdown += delayAndSpawnRate;
                 int side = Random.Range(1,4);
	        switch(side) 
			{
				case 1:
					randY = -7.7f;
			    	randX = Random.Range(-10.0f, 10.0f);
			    	break;
			  	case 2:
			  		randY = 7.7f;
			    	randX = Random.Range(-10.0f, 10.0f);
			    	break;
			  	case 3:
			    	randX = -9.6f;
			    	randY = Random.Range(-8.0f, 8.0f);
			    	break;
			    case 4:
			    	randX = 9.6f;
			    	randY = Random.Range(-8.0f, 8.0f);
			    	break;

			}
	        whereToSpawn = new Vector2(randX, randY);
            Instantiate(Enemy, whereToSpawn, Quaternion.identity);
             }
 
             // Should the spawn rate increase?
             if( spawnRateCountdown < 0 && delayAndSpawnRate > 1 )
             {
                 spawnRateCountdown += timeUntilSpawnRateIncrease;
                 delayAndSpawnRate -= 0.1f;
             }
         }
     }
 }
