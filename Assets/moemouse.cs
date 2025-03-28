using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraControl : MonoBehaviour
{
    public float sensitivity = 100f; 
    public Transform playerBody;
    private bool isRightMousePressed = false; 

    private float xRotation = 0f; 
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true; 
    }

    private void Update()
    {
        // ��Ǩ�ͺ��Ҽ����蹡���ԡ��Ҥ�ҧ
        if (Input.GetMouseButtonDown(1)) 
        {
            isRightMousePressed = true;
        }

        if (Input.GetMouseButtonUp(1)) 
        {
            isRightMousePressed = false;
        }

        if (isRightMousePressed)
        {
            // ��Ѻ������ͧ����ͤ�ԡ��Ҥ�ҧ
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f); 

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); 
            playerBody.Rotate(Vector3.up * mouseX); 
        }
    }
}