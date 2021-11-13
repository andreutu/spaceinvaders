using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D corp;
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        corp = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var input = Input.GetAxis("Horizontal");

        var position = corp.transform.position;
        var newPos = position + Vector3.right * input * moveSpeed * Time.deltaTime;

        corp.MovePosition(newPos);
    }
}
