using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Canvas MenuCanvas, MapCanvas, ShopCanvas;
    public UnityEngine.UI.Image desertImage, highwayImage, marsImage;

    // Start is called before the first frame update
    void Start()
    {
        MenuCanvas.enabled = true;
        MapCanvas.enabled = false;
        ShopCanvas.enabled = false;

        if(PlayerPrefs.GetInt("desert") == 0) desertImage.color = new Color(1, 1, 1, 0.3f);
        if(PlayerPrefs.GetInt("highway") == 0) highwayImage.color = new Color(1, 1, 1, 0.3f);
        if(PlayerPrefs.GetInt("mars") == 0) marsImage.color = new Color(1, 1, 1, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("desert") == 1) desertImage.color = new Color(255, 255, 255, 255);
        if(PlayerPrefs.GetInt("highway") == 1) highwayImage.color = new Color(255, 255, 255, 255);
        if(PlayerPrefs.GetInt("mars") == 1) marsImage.color = new Color(255, 255, 255, 255);
    }

    public void game(){
    	MenuCanvas.enabled = false;
        MapCanvas.enabled = true;
    }

    public void shop(){
        MenuCanvas.enabled = false;
        ShopCanvas.enabled = true;
    }

    public void back(){
        SceneManager.LoadScene("MainMenuScene");
    }

    public void exit(){
    	Application.Quit();
    }

    public void forest(){
        SceneManager.LoadScene("ForestScene");
    }

    public void desert(){
        if(PlayerPrefs.GetInt("desert") == 1) SceneManager.LoadScene("DesertScene");
    }

    public void highway(){
        if(PlayerPrefs.GetInt("highway") == 1) SceneManager.LoadScene("HighwayScene");
    }

    public void mars(){
        if(PlayerPrefs.GetInt("mars") == 1) SceneManager.LoadScene("MarsScene");
    }
}
