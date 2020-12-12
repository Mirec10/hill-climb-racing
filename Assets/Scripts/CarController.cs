using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameManager manager;

    public Rigidbody2D car_body;
    public Rigidbody2D back_tire;
    public Rigidbody2D front_tire;

    public float carTorque = 1000;
    public float speed = 100;
    public float movement;

    public float fuel = 1;
    public float fuelConsumption = 0.1f;
    public UnityEngine.UI.Image fuelImage;

    public GasScript gas;
    public BrakeScript brake;

    public bool finish = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = (brake.holding ? -1 : 0) + (gas.holding ? 1 : 0);

        fuelImage.fillAmount = fuel;

        if(finish){
            front_tire.angularVelocity = 0f;
            back_tire.angularVelocity = 0f;
            manager.win();
        }
    }

    void FixedUpdate()
    {
        if(finish) manager.win();

        if(fuel > 0){
            front_tire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            back_tire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            car_body.AddTorque(-movement * carTorque * Time.fixedDeltaTime);

            fuel -= fuelConsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
        }else{
            manager.lose();
        }
    }

}