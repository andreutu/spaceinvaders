using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D corp;
    public float moveSpeed = 10f;

    public GameObject bullet;

    public GameObject point1;
    public GameObject point2;
    
    void Start()
    {
        corp = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var input = Input.GetAxis("Horizontal");
        var fire = Input.GetAxis("Jump");

        if(Input.GetButton("Jump")) {
            Instantiate(bullet, point1.transform.position, Quaternion.identity);
            Instantiate(bullet, point2.transform.position, Quaternion.identity);

        }

        var position = corp.transform.position;
        var newPos = position + Vector3.right * input * moveSpeed * Time.deltaTime;

        corp.MovePosition(newPos);
    }
}
