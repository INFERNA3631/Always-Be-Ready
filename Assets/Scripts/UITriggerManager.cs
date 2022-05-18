using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITriggerManager : MonoBehaviour
{
    public UIObjectActivate[] UI;
    public Camera cam;
    public LayerMask mask;
    private bool IsCheckSelfTreatmentPossible = false;

    private void OnTriggerEnter(Collider col)
    {
        // 0 : Operation Description
        // 1 : Follow Team
        // 2 : Close To Injured
        // 3 : Injured Condition
        // 4 : Check Self Treatment
        // 5 : Use Tourniquet
        // 6 : Injured To Room

        switch (col.gameObject.tag)
        {
            case "Follow Team":
                Debug.Log("Follow Team");
                UIInitialization();
                UI[0].UIJustShow();
                UI[1].UIJustShow();
                Destroy(col.gameObject);
                break;
            case "Close To Injured":
                Debug.Log("Close To Injured");
                UIInitialization();
                UI[2].UIJustShow();
                Destroy(col.gameObject);
                break;
            case "Check Self Treatment":
                Debug.Log("Check Self Treatment");
                UIInitialization();
                UI[3].UIJustShow();
                UI[4].UIJustShow();
                Destroy(col.gameObject);
                break;
        }
    }

    public void UIInitialization()
    {
        for (int i = 0; i < UI.Length; i++)
        {
            UI[i].UIOFF();
        }
    }

    public void UseTourniquet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(transform.position, transform.forward * 100f, Color.blue, 0.3f);

            if (Physics.Raycast(ray, out hit, 100f, mask))
            {
                Debug.Log(".");
                UIInitialization();
                UI[3].UIJustShow();
                UI[6].UIJustShow();
                IsCheckSelfTreatmentPossible = true;
            }
        }
    }

    private void Update()
    {
        UseTourniquet();
    }
}
