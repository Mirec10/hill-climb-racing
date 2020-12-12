using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public Camera camera;
	public Canvas GameCanvas, PauseCanvas, WinCanvas, LoseCanvas;

    // Start is called before the first frame update
    void Start()
    {
    	Time.timeScale = 1;
    	
        GameCanvas.enabled = true;
        PauseCanvas.enabled = false;
        WinCanvas.enabled = false;
        LoseCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause(){
		Time.timeScale = 0;

		GameCanvas.enabled = false;
        PauseCanvas.enabled = true;
    }

    public void resume(){
    	Time.timeScale = 1;

    	GameCanvas.enabled = true;
        PauseCanvas.enabled = false;
    }

    public void restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void win(){
        GameCanvas.enabled = false;
        WinCanvas.enabled = true;
    }

    public void lose(){
        GameCanvas.enabled = false;
        LoseCanvas.enabled = true;
    }

    public void menu(){
        SceneManager.LoadScene("MainMenuScene");
    }
}
