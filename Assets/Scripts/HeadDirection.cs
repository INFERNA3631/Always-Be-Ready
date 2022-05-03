using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDirection : MonoBehaviour
{
    private RotateToMouse rotateToMouse; // 마우스 이동으로 카메라 회전

    private void Awake()
    {
        rotateToMouse = GetComponent<RotateToMouse>();

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
