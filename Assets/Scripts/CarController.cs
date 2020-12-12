using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	public Rigidbody2D car_body;
	public Rigidbody2D back_tire;
	public Rigidbody2D front_tire;

	public float carTorque = 10;
	public float speed = 100;
	private float movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate() {
		front_tire.AddTorque(-movement * speed * Time.fixedDeltaTime);
       	back_tire.AddTorque(-movement * speed * Time.fixedDeltaTime); 
       	car_body.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
	}

}
