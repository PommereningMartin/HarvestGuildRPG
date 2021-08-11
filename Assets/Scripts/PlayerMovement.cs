using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{

    public float speed;

    private Rigidbody2D myRidgidbody;

    private Vector3 velocity;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        if (velocity != Vector3.zero)
        {
            transform.position += velocity * Time.deltaTime * speed;
            animator.SetFloat("moveX", velocity.x);
            animator.SetFloat("moveY", velocity.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }

    }

    public override void OnStartLocalPlayer()
    {
        Camera.main.GetComponent<FollowPlayer>().setTarget(gameObject.transform);
    }
}
