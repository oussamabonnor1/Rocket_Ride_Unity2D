using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraBehaviour : MonoBehaviour {

	public Text scoreText;
	public Text loseText;
	public float score = 0f;
	public GameObject losePanel; 
	public Transform target;
	public float cameraSpeed = 5f;
	bool lostGame = false;

	
	// Update is called once per frame
	void LateUpdate () {
		if(!lostGame){
			if(target.transform.position.y > transform.position.y){
				transform.position = Vector3.Lerp(transform.position, 
					new Vector3(transform.position.x,target.transform.position.y,transform.position.z), cameraSpeed * Time.deltaTime);
				score += Time.deltaTime * 15f;
				scoreText.text = "Score: "+ (int) score;
			}
		}

	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag.Equals("Player")){
			lostGame = true;
			if(score > PlayerPrefs.GetInt("bestScore")) PlayerPrefs.SetInt("bestScore",(int) score);
			loseGame();
		}
	}

	void loseGame(){
		losePanel.SetActive(true);
		loseText.text = "Game over!\n Score: "+(int) score+ "\nBest score: "+PlayerPrefs.GetInt("bestScore");
		Destroy(target.gameObject);
	}

	public void quit(){
		Application.Quit();
	}
	public void startAgain(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
