using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivate : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public void UION()
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
    }

    public void UIOFF()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
