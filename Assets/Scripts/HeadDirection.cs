using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadDirection : MonoBehaviour
{
    private MouseManager rotateToMouse; // 마우스 이동으로 카메라 회전
    public CanvasGroup Option;
    public CanvasGroup Pause;

    private void Awake()
    {
        rotateToMouse = GetComponent<MouseManager>();

    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Operation")
        {
            if (Option.alpha == 0 && Pause.alpha == 0)
            {
                UpdateRotate();
            }
        }
    }

    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotateToMouse.UpdateRotate(mouseX, mouseY);
    }
}
