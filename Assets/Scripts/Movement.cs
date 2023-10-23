using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private GameObject camera;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float lateralSpeed = 5f;

    [SerializeField] private Vector3 offset = new Vector3(0, 7, -10);


    private float horizontalInput;
    private float verticalInput;
    
    
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");



        transform.Translate(Vector3.forward * speed *  Time.deltaTime * verticalInput);

        transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);

        

        camera.transform.position = transform.position + offset;

    }
}
