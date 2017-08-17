using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max ;
	int min ;
	int guess ;
	void Start () 
	{
		StartGame();	
	}
	
	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;
		
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, But don't tell me!");
		
		print ("the highest number you can pick is"+ max);
		print ("the lowest number you can pick is" + min);
		
		print ("is you number higer than" + guess);
		
		print ("Up = higer, Down = lower, Return = equals ");
		
		max = max + 1; 
				
	}
	
	
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Keypad8)){
			
			min = guess;
			NextGuess();
			
		}else if (Input.GetKeyDown(KeyCode.Keypad2)){
			
			max = guess;
			NextGuess();
			
		}else if (Input.GetKeyDown(KeyCode.Keypad5)){
			print("I win!!!");
			StartGame();
		}
	}
	void NextGuess()
	{
		guess = (max + min) / 2;
		
		print ("is you number higer than" + guess);
		print ("Up = higer, Down = lower, Return = equals ");	
		
	}
}
	