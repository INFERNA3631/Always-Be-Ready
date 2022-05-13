using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDirection : MonoBehaviour
{
    private MouseManager rotateToMouse; // ���콺 �̵����� ī�޶� ȸ��

    private void Awake()
    {
        rotateToMouse = GetComponent<MouseManager>();

    }

    private void Update()
    {
        UpdateRotate();
    }

    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotateToMouse.UpdateRotate(mouseX, mouseY);
    }
}
