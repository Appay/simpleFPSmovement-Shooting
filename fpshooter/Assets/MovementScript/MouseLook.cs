using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        // sağa sola yukarı aşağı bakma

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;//maus hareketleri ile çevreye baktırma
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);// clamp ile yukarı aşağı bakış açısına sınır getirdik arkasına direk bakamaz vb

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
        //-- sağa sola yukarı aşağı bakma

    }
}
