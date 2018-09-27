using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public Rigidbody player;
    public float speed = 1.2f;
    public Animator animator;

    void Start()
    {
        player.GetComponent<Rigidbody>();
        animator.GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        
        animator.SetFloat("Speed", 0f);

        if (input.x != 0 || input.z != 0)
        {
            animator.SetFloat("Speed", 0.75f);
        }
        player.MovePosition(transform.position + input * speed * Time.deltaTime);
    }
}
