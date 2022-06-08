using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public Camera cam;
    public float FromCam;

    void OnMouseDrag()
    {
        //���콺 ��ǥ�� �޾ƿ´�.
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, FromCam);
        //���콺 ��ǥ�� ��ũ�� �� ����� �ٲٰ� �� ��ü�� ��ġ�� ������ �ش�.
        this.transform.position = cam.ScreenToWorldPoint(mousePosition);
    }

    private void Update()
    {
        
    }
}
