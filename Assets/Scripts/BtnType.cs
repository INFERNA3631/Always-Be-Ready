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
                Debug.Log("���丮 ���");
                SceneManager.LoadScene("StorySelect");
                break;
            case BTNType.Train_Mode_Button:
                Debug.Log("�Ʒ� ���");
                break;
            case BTNType.Story_Mode_Chapter1_Button:
                Debug.Log("���丮 ��� é��1 ����");
                break ;
            case BTNType.Story_Mode_Chapter2_Button:
                Debug.Log("���丮 ��� é��2 ����");
                break ;
            case BTNType.To_Chapter1_Operation_Button:
                Debug.Log("���丮 ��� é��1 ���� ����");
                SceneManager.LoadScene("Operation");
                break;
            case BTNType.To_Main_Menu_Button:
                Debug.Log("���� �޴��� �̵�");
                SceneManager.LoadScene("MainMenu");
                break;
            case BTNType.To_Story_Selct_Button:
                Debug.Log("���丮 ���� â���� �̵�");
                SceneManager.LoadScene("StorySelect");
                break;
            case BTNType.To_Chaper1_Operation_Course_Button:
                Debug.Log("é�� 1 ���� �帧 â���� �̵�");
                SceneManager.LoadScene("OperationCourse");
                break;
            case BTNType.To_Pause_Button:
                Debug.Log("�Ͻ� ���� â���� �̵�");
                SceneManager.LoadScene("Pause");
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
