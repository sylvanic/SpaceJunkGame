using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float minScale = .8f;
    [SerializeField] float maxScale = 1.2f;

    [SerializeField] float rotationOffset = 100f;

    [SerializeField] float minMovementSpeed = 0;
    [SerializeField] float maxMovementSpeed = 0;
    private float movementSpeed = 0;

    Transform myT;
    Vector3 randomRotation;
    Rigidbody rb;

    void Awake()
    {
        myT = transform;
    }
    void Start()
    {
        //random scaling
        Vector3 scale = Vector3.one;
        scale.x = Random.Range(minScale, maxScale);
        scale.y = Random.Range(minScale, maxScale);
        scale.z = Random.Range(minScale, maxScale);
        myT.localScale = scale;

        //random rotation
        randomRotation.x = Random.Range(-rotationOffset, rotationOffset);
        randomRotation.y = Random.Range(-rotationOffset, rotationOffset);
        randomRotation.z = Random.Range(-rotationOffset, rotationOffset);

        //random speed
        movementSpeed = Random.Range(minMovementSpeed, maxMovementSpeed);


        // rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //VECTOR APPROACH
        myT.Rotate(randomRotation * Time.deltaTime);
        myT.position += myT.forward * movementSpeed * Time.deltaTime;




        //RIGIDBODY APPROACH   
        //rb.AddForce(Vector3.right * 5);
        // rb.AddForce(Vector3.forward * 5);
        // rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, 5, 5), Mathf.Clamp(rb.velocity.y, -5, 5));
    }
}
