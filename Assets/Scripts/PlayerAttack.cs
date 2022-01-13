using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	private float timeBTWattack;
	public float startTimeBTWattack;

	public Transform attackPos;
	public float attackRange;

	public LayerMask whatIsEnemies;

	public int damage;
    public int money=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(timeBTWattack<=0){
        	if(Input.GetKey(KeyCode.Space)){
        		//camAnim.SetTrigger("shake");
        		//PlayerAnim
        		Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position,attackRange,whatIsEnemies);
        		for(int i=0;i<enemiesToDamage.Length; i++){
        			enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
        		}
        	}
        	timeBTWattack=startTimeBTWattack;
        }
        else{
        	timeBTWattack-=Time.deltaTime;
        }
    }
    void OnDrawGizmosSelected(){
    	Gizmos.color=Color.red;
    	Gizmos.DrawWireSphere(attackPos.position,attackRange);
    }
    
}
