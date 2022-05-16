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
                Debug.Log("���� ���� UI Ȱ��");
                UIInitialization();
                UI[0].UIJustShow();
                UI[1].UIJustShow();
                Destroy(col.gameObject);
                break;
            case "Close To Injured":
                Debug.Log("�λ��ڿ� �����ϱ�");
                UIInitialization();
                UI[2].UIJustShow();
                Destroy(col.gameObject);
                break;
            case "Procedure Of Treatment":
                Debug.Log("�λ��� óġ");
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
