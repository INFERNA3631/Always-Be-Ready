using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public ObjectActivate UI;

    private void OnTriggerEnter(Collider col)
    {
        switch(col.gameObject.tag)
        {
            case "Player":
                Debug.Log("���� ���� UI Ȱ��");
                UI.UION();
                break;
        }
    }
}
