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
                Debug.Log("ㄱ자 복토 UI 활성");
                UI.UION();
                break;
        }
    }
}
