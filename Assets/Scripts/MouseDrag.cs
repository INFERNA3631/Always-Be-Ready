using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public Camera cam;
    public float FromCam;

    void OnMouseDrag()
    {
        //마우스 좌표를 받아온다.
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, FromCam);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = cam.ScreenToWorldPoint(mousePosition);
    }

    private void Update()
    {
        
    }
}
