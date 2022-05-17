using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public ObjectActivate[] UI;
    public Camera cam;
    public LayerMask mask;

    private void OnTriggerEnter(Collider col)
    {
        switch(col.gameObject.tag)
        {
            case "L-Shaped Hallway":
                Debug.Log("ㄱ자 복토 UI 활성");
                UIInitialization();
                UI[0].UIJustShow();
                UI[1].UIJustShow();
                Destroy(col.gameObject);
                break;
            case "Close To Injured":
                Debug.Log("부상자에 접근하기");
                UIInitialization();
                UI[2].UIJustShow();
                Destroy(col.gameObject);
                break;
            case "Procedure Of Treatment":
                Debug.Log("부상자 처치");
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

    private void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(transform.position, transform.forward * 100f, Color.blue, 0.3f);

            if (Physics.Raycast(ray, out hit, 100f, mask))
            {
                Debug.Log(hit.collider.name);
                UIInitialization();
                UI[3].UIJustShow();
                UI[5].UIJustShow();
            }
        }
    }
}
