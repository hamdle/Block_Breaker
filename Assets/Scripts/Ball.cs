using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Paddle paddle;

	private Vector3 paddleToBallVector;
	private bool hasStarted = false;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;

		this.GetComponent<Rigidbody2D>().simulated = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (!hasStarted)
		{
			// Lock ball relative to paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;

			// Wait for mouse press to launch ball
			if (Input.GetMouseButtonDown(0))
			{
				this.GetComponent<Rigidbody2D>().simulated = true;

				hasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 10f);
			}
		}
	}
}
