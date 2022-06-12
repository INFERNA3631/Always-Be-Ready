using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InjuredTriggerManager : MonoBehaviour
{
    public UIObjectActivate[] UI;
    private bool CanDrag = false;
    private bool CanTourniquet = false;
    private bool ReTourniquet = false;
    private bool IsCheck = false;
    private bool ActiveTimer = false;
    public float RayLength;
    public LayerMask mask;
    private float Timer = 10;
    public Text text_Timer;

    public Camera cam;
    public float FromCam;

    private void OnTriggerEnter(Collider col)
    {
        // 0 : Use Tourniquet
        // 1 : Injured To Room
        // 2 : Double Check Tourniquet
        // 3 : Injured Condition
        // 4 : Check Self Treatment
        // 5 : Use Tourniquet
        // 6 : Injured To Room

        if (CanTourniquet)
        {
            switch (col.gameObject.tag)
            {
                case "Tourniquet":
                    Debug.Log("Tourniquet");
                    UIInitialization();
                    UI[1].UIJustShow();
                    Destroy(col.gameObject);
                    CanDrag = true;
                    break;
            }
        }

        switch (col.gameObject.tag)
        {
            case "Injured Place":
                Debug.Log("Injured Place");
                UIInitialization();
                UI[2].UIJustShow();
                Destroy(col.gameObject);
                CanDrag = false;
                ReTourniquet = true;
                break;
        }

        if (ReTourniquet)
        {
            switch (col.gameObject.tag)
            {
                case "Tourniquet":
                    Debug.Log("Tourniquet");
                    UIInitialization();
                    UI[6].UIJustShow();
                    Destroy(col.gameObject);
                    CanDrag = false;
                    ActiveTimer = true;
                    break;
            }
        }
    }

    private void Update()
    {
        if (!IsCheck)
        {
            UseTourniquet();
        }

        if (ActiveTimer)
        {
            PressTourniquetTimer();
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

    public void UseTourniquet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(transform.position, transform.forward * RayLength, Color.blue, 0.3f);

            if (Physics.Raycast(ray, out hit, RayLength, mask))
            {
                Debug.Log("Use Tourniquet");
                UIInitialization();
                UI[3].UIJustShow();
                UI[5].UIJustShow();
                CanTourniquet = true;
                IsCheck = true;
            }
        }
    }

    public void PressTourniquetTimer()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(transform.position, transform.forward * RayLength, Color.blue, 0.3f);

            if (Physics.Raycast(ray, out hit, RayLength, mask))
            {
                Debug.Log("Press Tourniquet");
                UI[7].UIJustShow();
                UI[8].UIJustShow();
                Timer -= Time.deltaTime;
                text_Timer.text = $"{Timer:N1}";

                if (Timer < 0)
                {
                    UIInitialization();
                    UI[9].UIInteraction();
                    ActiveTimer = false;
                }
            }
        }
        else
        {
            UI[7].UIOFF();
            UI[8].UIOFF();
            Timer = 10;
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
