using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePhysics : MonoBehaviour
{
    [SerializeField] private float SpeedMultiplier = 1f;

    private Vector3 lastFrameVelocity;
    public Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Particle is given a random velocity vector at start
        float randNum = Random.Range(1f, 4f) * SpeedMultiplier;
        rb.velocity = new Vector3(0, -randNum, randNum);
        //Note: could implement a multiplier for different particle speeds

    }

    // Update is called once per frame
    void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {

        Bounce(collision.contacts[0].normal);

    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        //Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, 2 * SpeedMultiplier);
    }
}

