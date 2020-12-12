using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounterScript : MonoBehaviour
{
	public UnityEngine.UI.Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = PlayerPrefs.GetInt("coins") + "";
    }
}
