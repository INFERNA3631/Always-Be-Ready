using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BtnType : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Story_Mode_Button:
                Debug.Log("스토리 모드");
                SceneManager.LoadScene("StorySelect");
                break;
            case BTNType.Train_Mode_Button:
                Debug.Log("훈련 모드");
                break;
            case BTNType.Story_Mode_Chapter1_Button:
                Debug.Log("스토리 모드 챕터1 선택");
                break ;
            case BTNType.Story_Mode_Chapter2_Button:
                Debug.Log("스토리 모드 챕터2 선택");
                break ;
            case BTNType.Chapter1_Start_Operation_Button:
                Debug.Log("스토리 모드 챕터1 작전 시작");
                SceneManager.LoadScene("Operation");
                break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.1f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
