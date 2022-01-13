using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 30;
    public int money =0;
    void Start()
    {
        
    }
    public void TakeDamage () 
	    {
 			
			if (health <= 0)
	    	{
	    		Die();
	    		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	    		//DieTime = Time.time;
				
			}
	    }
    // Update is called once per frame
    void Update()
    {
        health -= 1 * Time.deltaTime ;
		//Debug.Log(health);
    }
    void Die ()
	    {
	    	
	    	Destroy(gameObject);
	    	
	    }
}
