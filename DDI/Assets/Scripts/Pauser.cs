using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class Pauser : MonoBehaviour {
	private bool paused = false;
	public GameObject pausePanel;
	public GameObject pauseButton;
	public GameObject panel2;
	public AudioSource audioSource;
	bool soundToggle = true;
	public Gun armita;

	
	
	// Update is called once per frame
	void Update () {
	
		audioSource = GetComponent<AudioSource>();
		
		if(Input.GetKeyUp(KeyCode.P))
		{
			
			paused = !paused; //con la tecla t
			pausePanel.SetActive(paused);
			pauseButton.gameObject.SetActive(false);
			
		}

		if(paused){
			Time.timeScale = 0; //lentp pausa
			pausePanel.SetActive(paused);
			armita.GetComponent<AudioSource>().Pause();
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
			//pauseButton.gameObject.SetActive(false);
		}
		else{
			Time.timeScale = 1;	//rapido juegas
			pausePanel.SetActive(paused);
		}
			
			
	}
	
	public void ResetGame(){
			Debug.Log("ResetGame...");
			SceneManager.LoadScene(0);
	}
	
	public void MuteMusic(){
		 
       soundToggle = !soundToggle;
	if(!soundToggle)
	{
	   audioSource.mute = !audioSource.mute;
	}
	else
		{
		
		audioSource.mute = false;
		
		}

	}
	
	public void PauseGame(){
		
		paused = !paused; 
		pausePanel.SetActive(paused);
		 
		
		if(!paused){
			panel2.gameObject.SetActive(false); //no se me desactiva.
			Time.timeScale = 0; //pausa
			pausePanel.SetActive(!paused);
			panel2.SetActive(paused);
			armita.GetComponent<AudioSource>().Pause();
			
		}
		else{
			Time.timeScale = 1;	//jegas
			pausePanel.SetActive(!paused);
			

		}
	}
	
	
	
}
	
	

