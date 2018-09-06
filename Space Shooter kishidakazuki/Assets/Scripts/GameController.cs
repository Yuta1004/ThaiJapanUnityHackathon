using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Text scoreText;
    public Text bonusText;
    public int bonusScore;

    private bool gameOver;
    private int score;

	// Use this for initialization
	void Start (){

        gameOver = false;
        bonusText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
	}

    IEnumerator SpawnWaves(){

        yield return new WaitForSeconds(startWait);
        while (true){
            
            for (int i = 0; i < hazardCount; i++){
                
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition =
                    new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                                hazard.transform.position.y, 
                                spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            if (gameOver){
                break;
            }
        }
    }

    public void AddScore(int newScoreValue){
        
        score += newScoreValue;
        UpdateScore();
    }
    void UpdateScore(){
        
        scoreText.text = "Score: " + score;
    }

    public void Bonus(){

        score += bonusScore;
        UpdateScore();
        bonusText.text = "+" + bonusScore + "BONUS";
        Invoke("DefBonusText", 0.5f);
    }

    void DefBonusText(){
        bonusText.text = "";
    }

    public void GameOver(){
        
        gameOver = true;
    }
}
