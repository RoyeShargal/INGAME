using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
     private float latestDirectionChangeTime;
 private readonly float directionChangeTime = 3f;
 public float speed ;
 private Vector2 movementDirection;
 private Vector2 movementPerSecond;
 public GameObject bloodEffect;
 Player player;
 public int health;
 
 private float dazedTime;
 public float startDazedTime=0.6f;
 
 void Start(){
     latestDirectionChangeTime = 0f;
     calcuateNewMovementVector();
     player = FindObjectOfType<Player>();

 }
 
 void calcuateNewMovementVector(){
    //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
     movementDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
     movementPerSecond = movementDirection * speed;
 }
 
 void Update(){
    /*
    if(dazedTime<=0){
        this.speed=1;
    }
    else{
        speed=0;
        dazedTime=Time.deltaTime;
     //if the changeTime was reached, calculate a new movement vector
    }
    */

    if(health<=0){
        
            player.money++;
            Destroy(gameObject);
        }
    

     if (Time.time - latestDirectionChangeTime > directionChangeTime){
         latestDirectionChangeTime = Time.time;
         calcuateNewMovementVector();
     }
     //move enemy: 
     transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime), 
     transform.position.y + (movementPerSecond.y * Time.deltaTime));
 
 }
 public void TakeDamage(int damage){
    //Instantiate(bloodEffect);
    dazedTime = startDazedTime;
    health-=damage;
    Debug.Log("damage taken");
 }
}