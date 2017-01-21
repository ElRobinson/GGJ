using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pecas : MonoBehaviour {

    // z+ foge, z- aproxima
    // value that add in that category type
    public float speed;
    public int xOffset;
    public int yOffset;

    GameObject[] randowObject;

    private Character character;

    void Start()
    {
        Vector3 newPosition = transform.position;
        int randomX = Random.Range(-xOffset, xOffset);
        int randomY = Random.Range(0, yOffset);

        newPosition.x += randomX;
        newPosition.y += randomY;
        transform.position = newPosition;

        character = GameObject.Find("Main Camera").GetComponent<Character>();
    }
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z -= character.speed * Time.deltaTime;
        transform.position = newPosition;

    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name);
    }

    void OnTriggerEnter(Collider collider) {
        Debug.Log(collider.gameObject.name);
        Character character = collider.gameObject.GetComponent<Character>();

        if (collider.gameObject.name.Equals("Peca1(Clone)")) {
            character.TakeDamage(5);
        } else {
            character.GainLife(5);
        }

        Destroy(gameObject);
        
    }
}
