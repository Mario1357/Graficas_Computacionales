using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rigid;
    public Vector2 turn;
    public float sensitivity = 1.5f;
    public Vector3 deltaMove;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotation();
    }

    void Move(){
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(transform.forward * velocidad);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(transform.forward * -velocidad);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(transform.right * -velocidad);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(transform.right * velocidad);
        }
    }

    void Rotation(){
        turn.x += Input.GetAxis("Mouse X") * sensitivity*5;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}

