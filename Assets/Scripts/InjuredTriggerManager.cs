using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InjuredTriggerManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        // 0 : Operation Description
        // 1 : Follow Team

        switch (col.gameObject.tag)
        {
            case "Tourniquet":
                Debug.Log("Tourniquet");
                Destroy(col.gameObject);
                break;
            case "Close To Injured":
                Debug.Log("Close To Injured");
                Destroy(col.gameObject);
                break;
        }
    }
}
