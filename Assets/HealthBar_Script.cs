using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Script : MonoBehaviour
{
	private Text HealthBar;
	public float CurrentHealth;
	private float MaxHealth = 200;
	private float secondsCount=0;
     private int minuteCount = 0 ;
	public Text timerText;
	Player Player;

	private void Start() 
	{
		//Find
		HealthBar = GetComponent<Text>();
		Player = FindObjectOfType<Player>();

	}

	private void Update() 
	{
		CurrentHealth = Player.health;
		HealthBar.text = minuteCount+":"+(int)secondsCount+"\n";
		HealthBar.text += "HP: "+((int)CurrentHealth).ToString()+"\n";
		HealthBar.text += "MONEY:" + (Player.money).ToString()+"\n";
		//HealthBar.text += "EGGS:" ;
		
		//timer:
		secondsCount += Time.deltaTime;
         //timerText.text = hourCount +"h:"+ minuteCount +"m:"+(int)secondsCount + "s";
         if(secondsCount >= 60){
             minuteCount++;
             secondsCount = 0;
         }


	}
}


