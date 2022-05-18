using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public Camera cam;
    public float fromCam = 2;

    void OnMouseDrag()
    {
        //���콺 ��ǥ�� �޾ƿ´�.
        Vector3 mousePosition
            = new Vector3(Input.mousePosition.x, Input.mousePosition.y, fromCam);
        //���콺 ��ǥ�� ��ũ�� �� ����� �ٲٰ� �� ��ü�� ��ġ�� ������ �ش�.
        this.transform.position = cam.ScreenToWorldPoint(mousePosition);
    }
}
