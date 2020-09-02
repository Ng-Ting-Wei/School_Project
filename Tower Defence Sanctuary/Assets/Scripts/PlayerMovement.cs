using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float panSpeed = 35f;
    private float panborderThicken = 10f;
    private float scrollSpeed = 20f;
    private float minY = 20f;
    private float maxY = 80f;
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
        if (Input.GetKey(KeyCode.LeftShift))
        {
            panSpeed = 75f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            panSpeed = 35f;
        }
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
        //Zoom
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 50f * Time.deltaTime;
        //Restrictions
        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);
        transform.position = pos;
        //Pause menu

    }
}
