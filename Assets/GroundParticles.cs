using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GroundParticles : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] ParticleSystem groundParticles;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        groundParticles.Play();
    }
    private void OnCollisionExit2D(Collision2D other) 
    {
        groundParticles.Stop();
    }
    void Start() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update() 
    {
        groundParticles.startSpeed = (rb2d.velocity.x + rb2d.velocity.y) / 2;
    }
}
