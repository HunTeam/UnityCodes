using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    float mouseX;
    float mouseY;
    public float sen = 100f;

    public Transform player;
    float rotation = 0;
   
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sen * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sen * Time.deltaTime;

        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotation, 0, 0);
        player.Rotate(Vector3.up * mouseX);
    }
}
