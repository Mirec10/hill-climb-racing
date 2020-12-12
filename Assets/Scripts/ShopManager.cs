using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public UnityEngine.UI.Image desertImage, highwayImage, marsImage;

    // Start is called before the first frame update
    void Start()
    {
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

    public void desert(){
    	int coins = PlayerPrefs.GetInt("coins");

    	if(coins >= 200 && (PlayerPrefs.GetInt("desert") == 0)){
    		PlayerPrefs.SetInt("desert", 1);
    		PlayerPrefs.SetInt("coins", coins - 200);
    	}
    }

    public void highway(){
    	int coins = PlayerPrefs.GetInt("coins");

    	if(coins >= 2500 && (PlayerPrefs.GetInt("highway") == 0)){
    		PlayerPrefs.SetInt("highway", 1);
    		PlayerPrefs.SetInt("coins", coins - 2500);
    	}
    }

    public void mars(){
    	int coins = PlayerPrefs.GetInt("coins");

    	if(coins >= 12000 && (PlayerPrefs.GetInt("mars") == 0)){
    		PlayerPrefs.SetInt("mars", 1);
    		PlayerPrefs.SetInt("coins", coins - 12000);
    	}
    }
}
