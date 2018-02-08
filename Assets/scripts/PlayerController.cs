using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float panSpeed;
    private Rigidbody rb;


	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(moveHorizontal * Time.deltaTime * speed, 0f, moveVertical * Time.deltaTime*speed);


		//Modifed from https://gamedev.stackexchange.com/questions/104693/how-to-use-input-getaxismouse-x-y-to-rotate-the-camera
	
	
		pitch -= speedV * Input.GetAxis("Mouse Y");
		yaw += speedH * Input.GetAxis("Mouse X");


		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}
