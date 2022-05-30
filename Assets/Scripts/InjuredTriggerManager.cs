using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InjuredTriggerManager : MonoBehaviour
{
    public UIObjectActivate[] UI;
    private bool CanDrag = false;

    public Camera cam;
    public float FromCam;

    private void OnTriggerEnter(Collider col)
    {
        // 0 : Operation Description
        // 1 : Follow Team

        switch (col.gameObject.tag)
        {
            case "Tourniquet":
                Debug.Log("Tourniquet");
                UIInitialization();
                UI[1].UIJustShow();
                Destroy(col.gameObject);
                CanDrag = true;
                break;
            case "Close To Injured":
                Debug.Log("Close To Injured");
                Destroy(col.gameObject);
                break;
        }
    }

    
    void OnMouseDrag()
    {
        if (CanDrag)
        {
            //마우스 좌표를 받아온다.
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, FromCam);
            //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
            this.transform.position = cam.ScreenToWorldPoint(mousePosition);
        }
    }

    public void UIInitialization()
    {
        for (int i = 0; i < UI.Length; i++)
        {
            UI[i].UIOFF();
        }
    }
}
