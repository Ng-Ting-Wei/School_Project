using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float panSpeed = 35f;
    private float panborderThicken = 10f;
    private float cameraRotation = 35f;
    public Vector2 panLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    public void playerMovement()
    {
        //Movement
        Vector3 pos = transform.position;
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panborderThicken)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panborderThicken)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panborderThicken)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panborderThicken)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);
        transform.position = pos;
        //Rotation 
        Vector3 rotation = transform.eulerAngles;
        if (Input.GetKey(KeyCode.Q))
        {
            rotation.y += cameraRotation * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotation.y -= cameraRotation * Time.deltaTime;
        }
        transform.eulerAngles = rotation;
    }
}
