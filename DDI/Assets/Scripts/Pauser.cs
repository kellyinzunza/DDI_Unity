using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pauser : MonoBehaviour {
	private bool paused = false;
	public GameObject pausePanel;
	public GameObject pauseButton;
	//private AudioSource audio;
	//public GameObject audioSource;
	//bool soundToggle = true;

	
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.P))
		{
			
			paused = !paused; //con la tecla t
			pausePanel.SetActive(paused);
		}

		if(paused){
			Time.timeScale = 0; //lentp pausa
			pausePanel.SetActive(paused);
			//pauseButton.gameObject.SetActive(false); 
		}
		else{
			Time.timeScale = 1;	//rapido juegas
			pausePanel.SetActive(paused);
		}
	}
	
	public void ContinueGame(){
			
				Time.timeScale = 1;	//rapido juegas
			Debug.Log("Continuar...");
			paused = !paused; //con la tecla t
			pausePanel.SetActive(paused);
		if(paused){
			Time.timeScale = 0; //lentp pausa
			pausePanel.SetActive(paused);
		}
		else{
			Time.timeScale = 1;	//rapido juegas
			pausePanel.SetActive(paused);
		}
			
			
	}
	
	public void ResetGame(){
			Debug.Log("ResetGame...");
			//SceneManager.LoadScene(0);
			SceneManager.LoadScene(0);
	}
	
	public void MuteMusic(){
		 
        /*soundToggle = !soundToggle;
		 audio = GetComponent<AudioSource> ();
		 if(soundToggle)
		 {
		  // audioSource.SetActive(true);
		 audio.Play ();
		 }
		 else{
		  // audioSo
		
		audio.Pause();
		 }
    */

	}
	
	public void PauseGame(){
		
		paused = !paused; 
		pausePanel.SetActive(paused);
		//pauseButton.gameObject.SetActive(false); 
		
		if(paused){
			Time.timeScale = 0; //pausa
			pausePanel.SetActive(paused);

			
		}
		else{
			Time.timeScale = 1;	//jegas
			pausePanel.SetActive(paused);
		

		}
	}
	
	
	
}
	
	
	
	
	
	
	

