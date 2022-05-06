using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    ObjectActivate UI;

    private void OnTriggerEnter(Collider col)
    {
        switch(col.tag)
        {
            case "L_Hallway":
                Debug.Log("ㄱ자 복토 UI 활성");
                UI.UION();
                break;
        }
    }
}
