using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour {
	private bool paused = false;
	public GameObject pausePanel;
	
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
		
	}
	
	public void MuteMusic(){
			Debug.Log("Mute music");
		
	}
	
	
	
}
