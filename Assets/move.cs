using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	public float speed = 0.5f; // public float xPos; public float yPos;
    public Vector3 desiredPos;
    public float xPos;
     public float yPos;
 public float timer = 1f;
 public float timerSpeed;
 public float timeToMove;
      void Start()
 {
     yPos = Random.Range(-0f, 10f);
     xPos = Random.Range(-100f,100f);
   //  xPos = Random.Range(-4.5f, 4.5f);
     desiredPos = new Vector3(transform.position.x, yPos, transform.position.z);
 }

 void Update()
 {
     timer += Time.deltaTime * timerSpeed;
     if (timer >= timeToMove)
     {
 transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);         if (Vector3.Distance(transform.position, desiredPos) <= 0.01f)
         {
             yPos = Random.Range(-0f, 10f);
             xPos = Random.Range(-0f,10f);
            // xPos = Random.Range(-7f, 4.5f);
             desiredPos = new Vector3(transform.position.x, yPos, transform.position.z);
             
             timer = 0.0f;
         }
     }
 }

 }