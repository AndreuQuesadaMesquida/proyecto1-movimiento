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


        
        transform.Rotate(Vector3.up, lateralSpeed * Time.deltaTime * horizontalInput);


        transform.Translate(Vector3.forward * speed *  Time.deltaTime * verticalInput);

        // transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);

        

        

        

    }

    private void LateUpdate()
    {
        camera.transform.position = transform.position + offset;
    }
}
