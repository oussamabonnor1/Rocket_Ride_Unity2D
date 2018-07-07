using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject padPrefab;
	public GameObject superPadPrefab;
	public int numPadsToMake = 10;
	int indexToCheck = 5;
	int indexToTanslate = 0;
	private float levelWidth;
	public float minVerticalDistance, maxVerticalDistance;
	List<GameObject> pads = new List<GameObject>();
	Vector2 spawnPosition;
	bool superCharge = false;

	// Use this for initialization
	void Start () {
			spawnPosition = transform.position;
			levelWidth = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height)).x - padPrefab.GetComponent<SpriteRenderer>().bounds.extents.x / 2f;
			makePads();
		}

	void Update(){
		if(indexToCheck < pads.Count){
			if(transform.position.y >= pads[indexToCheck].transform.position.y){
				translatePad(indexToTanslate);
			}
		}
	}


	void makePads(){
		for(int i=0; i< numPadsToMake; i++){
			makePad();
		}
	}

	void makePad(){
		spawnPosition = new Vector2(0f,spawnPosition.y);
		spawnPosition += new Vector2(Random.Range(-levelWidth,levelWidth), Random.Range(minVerticalDistance,maxVerticalDistance));
		GameObject padTemp = null;
		if(!superCharge){
			if(Random.Range(0,3) == 0){
				superCharge = true;
				padTemp = Instantiate(superPadPrefab, spawnPosition , Quaternion.identity);	
			}else padTemp = Instantiate(padPrefab, spawnPosition , Quaternion.identity);
		}else{
			padTemp = Instantiate(padPrefab, spawnPosition , Quaternion.identity);
		}
		print(padTemp);
		pads.Add(padTemp);
	}

	void translatePad(int padIndex){
		pads[padIndex].transform.position = new Vector2(0f,pads[padIndex].transform.position.y);
		spawnPosition = new Vector2(0f,spawnPosition.y);
		spawnPosition += new Vector2(Random.Range(-levelWidth,levelWidth), Random.Range(minVerticalDistance,maxVerticalDistance));
		pads[padIndex].transform.position = spawnPosition;
		StartCoroutine(growPad(pads[padIndex]));
		if(indexToTanslate < pads.Count - 1) indexToTanslate++;
		else indexToTanslate = 0; 
		indexToCheck = (indexToTanslate+5) % (pads.Count-1);
	}

	IEnumerator growPad(GameObject obj){
		for(int i=0; i <=10; i++){
			float k = (float) i /10;
			obj.transform.localScale = new Vector3(k,k,k);
			yield return new WaitForSeconds(0.01f);
		}
	}
	
}
