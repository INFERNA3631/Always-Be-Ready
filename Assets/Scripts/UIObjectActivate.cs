using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObjectActivate : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public void UIInteraction()
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
    }

    public void UIJustShow()
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = false;
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
