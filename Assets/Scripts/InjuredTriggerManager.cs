using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InjuredTriggerManager : MonoBehaviour
{
    public UIObjectActivate[] UI;
    private bool CanDrag = false;
    private bool CanTourniquet = false;

    public Camera cam;
    public float FromCam;

    private void OnTriggerEnter(Collider col)
    {
        // 0 : Use Tourniquet
        // 1 : Injured To Room
        // 2 : Double Check Tourniquet

        switch (col.gameObject.tag)
        {
            case "Tourniquet":
                Debug.Log("Tourniquet");
                UIInitialization();
                UI[1].UIJustShow();
                Destroy(col.gameObject);
                CanDrag = true;
                break;
            case "Injured Place":
                Debug.Log("Injured Place");
                UIInitialization();
                UI[2].UIJustShow();
                Destroy(col.gameObject);
                CanDrag = false;
                CanTourniquet = true;
                break;
        }
    }

    
    void OnMouseDrag()
    {
        if (CanDrag)
        {
            //���콺 ��ǥ�� �޾ƿ´�.
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, FromCam);
            //���콺 ��ǥ�� ��ũ�� �� ����� �ٲٰ� �� ��ü�� ��ġ�� ������ �ش�.
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
