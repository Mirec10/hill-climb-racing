using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void game(){
    	SceneManager.LoadScene("ForestScene");
    }

    public void shop(){

    }

    public void exit(){
    	Application.Quit();
    }
}
