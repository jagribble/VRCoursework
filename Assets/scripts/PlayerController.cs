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

		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");



        // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(moveHorizontal * Time.deltaTime * speed, 0f, moveVertical * Time.deltaTime*speed);


		//https://gamedev.stackexchange.com/questions/104693/how-to-use-input-getaxismouse-x-y-to-rotate-the-camera
		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
//
//        Camera mycam = GetComponent<Camera>();
//        float sensitivity = 0.05f;
//        Vector3 vp = mycam.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane));
//        vp.x -= 0.5f;
//        vp.y -= 0.5f;
//        vp.x *= sensitivity;
//        vp.y *= sensitivity;
//        vp.x += 0.5f;
//        vp.y += 0.5f;
//        Vector3 sp = mycam.ViewportToScreenPoint(vp);
//
//        Vector3 v = mycam.ScreenToWorldPoint(sp);
//        transform.LookAt(v, Vector3.up);
    }
}
