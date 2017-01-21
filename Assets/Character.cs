using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public float speed;
    public float life;
    public float speedGlobal;
    public bool isPressedVertical;
    public bool isPressedHorizontal;
    public float lerpSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        isPressedHorizontal = false;
        isPressedVertical = false;

        if (Input.GetKeyDown("q")) speed -= 0.25f;
        if (Input.GetKeyDown("w")) speed += 0.25f;

        if (Input.GetKey("b"))
        {
            isPressedHorizontal = true;
            Vector3 newPosition = transform.position;
            newPosition.x += speedGlobal * Time.deltaTime;
            transform.position = newPosition;

            Vector3 angles = transform.eulerAngles;
            angles.y = Mathf.Lerp(angles.y, 135, lerpSpeed * Time.deltaTime);
            transform.eulerAngles = angles;
        }
        if (Input.GetKey("n"))
        {
            isPressedHorizontal = true;
            Vector3 newPosition = transform.position;
            newPosition.x -= speedGlobal * Time.deltaTime;
            transform.position = newPosition;

            Vector3 angles = transform.eulerAngles;
            angles.y = Mathf.Lerp(angles.y, 225, lerpSpeed * Time.deltaTime);
            transform.eulerAngles = angles;
        }

        if (!isPressedHorizontal) {
            Vector3 newPosition = transform.position;
            
            newPosition.y += speedGlobal * Time.deltaTime;

            Vector3 angles = transform.eulerAngles;
            angles.y = Mathf.Lerp(angles.y, 180, lerpSpeed * Time.deltaTime);
            transform.eulerAngles = angles;
        }

        if (Input.GetKey("o"))
        {
            isPressedVertical = true;

            Vector3 newPosition = transform.position;
            newPosition.y += speedGlobal * Time.deltaTime;
            transform.position = newPosition;

            Vector3 angles = transform.eulerAngles;
            angles.x = -30;
            transform.eulerAngles = angles;
            
        }

        if (Input.GetKey("p"))
        {
            isPressedVertical = true;

            Vector3 newPosition = transform.position;
            newPosition.y -= speedGlobal * Time.deltaTime;
            transform.position = newPosition;

            Vector3 angles = transform.eulerAngles;
            angles.x = 30;
            transform.eulerAngles = angles;

        }

        if (!isPressedVertical)
        {
            Vector3 newPosition = transform.position;

            newPosition.x += speedGlobal * Time.deltaTime;

            Vector3 angles = transform.eulerAngles;
            angles.x = 0;
            transform.eulerAngles = angles;
            //transform.position = newPosition;
        }

    }

    public void TakeDamage(int value)
    {
        life -= value;
        Debug.Log("TakeDamage" + life);
    }

    public void GainLife(int value)
    {
        life += value;
        Debug.Log("GainLife" + life);
    }
}
