using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    bool isGrounded;
    [SerializeField] float torqueAmount = 1;
    [SerializeField] float speed = 1;
    Rigidbody2D rb2d;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D other) 
    {
        isGrounded = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            if(Input.GetKey(KeyCode.D))
            {
                rb2d.AddTorque(-torqueAmount);
            }
            else if(Input.GetKey(KeyCode.A))
            {
                rb2d.AddTorque(torqueAmount);
            }
            if(Input.GetKey(KeyCode.W) && isGrounded)
            {
                rb2d.AddRelativeForce(new Vector3(speed, 0, 0));
            }
        }
        
    }
    public void DisableControls()
    {
        canMove = false;
    }
}
