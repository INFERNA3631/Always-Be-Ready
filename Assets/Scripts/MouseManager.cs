using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    // ī�޶� x, y�� ȸ���ӵ�
    public float rotCamXAxisSpeed = 5;
    public float rotCamYAxisSpeed = 3;

    private float eulerAngleX;
    private float eulerAngleY;
    private float limitMinX = -80; // ī�޶� ��/�Ʒ� ȸ�� ����(��)
    private float limitMaxX = 50; // ī�޶� ��/�Ʒ� ȸ�� ����(�Ʒ�)

    public void SetXAxisSpeed(float speed)
    {
        rotCamXAxisSpeed = speed;
        Debug.Log(speed);
    }
    public void SetYAxisSpeed(float speed)
    {
        rotCamYAxisSpeed = speed;
        Debug.Log(speed);
    }

    public void UpdateRotate(float mouseX, float mouseY)
    {
        eulerAngleY += mouseX * rotCamXAxisSpeed; // ���콺 ��/�� �̵����� ī�޶� y�� ȸ��
        eulerAngleX -= mouseY * rotCamYAxisSpeed; // ���콺 ��/�Ʒ� �̵����� ī�޶� x�� ȸ��

        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);

        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY, 0);
    }

    public float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
