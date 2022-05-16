using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public ObjectActivate[] UI;

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
}
