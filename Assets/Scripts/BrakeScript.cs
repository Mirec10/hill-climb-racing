using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BrakeScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
	public Sprite onDown;
    public Sprite onUp;
    public Image image;

    public bool holding = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        holding = true;
        image.sprite = onDown;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        holding = false;
        image.sprite = onUp;
    }
}
