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
    private string preScene;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Go_Back:
                Debug.Log("�ڷΰ���");
                SceneManager.LoadScene(preScene);
                break;
            case BTNType.Story_Mode_Button:
                Debug.Log("���丮 ���");
                SceneManager.LoadScene("StorySelect");
                EnableCursor();
                break;
            case BTNType.Train_Mode_Button:
                Debug.Log("�Ʒ� ���");
                break;
            case BTNType.Story_Mode_Chapter1_Button:
                Debug.Log("���丮 ��� é��1 ����");
                EnableCursor();
                break;
            case BTNType.Story_Mode_Chapter2_Button:
                Debug.Log("���丮 ��� é��2 ����");
                break ;
            case BTNType.To_Chapter1_Operation_Button:
                Debug.Log("���丮 ��� é��1 ���� ����");
                SceneManager.LoadScene("Operation");
                DisableCursor();
                break;
            case BTNType.To_Main_Menu_Button:
                Debug.Log("���� �޴��� �̵�");
                SceneManager.LoadScene("MainMenu");
                EnableCursor();
                break;
            case BTNType.To_Story_Selct_Button:
                Debug.Log("���丮 ���� â���� �̵�");
                SceneManager.LoadScene("StorySelect");
                EnableCursor();
                break;
            case BTNType.To_Chaper1_Operation_Course_Button:
                Debug.Log("é�� 1 ���� �帧 â���� �̵�");
                SceneManager.LoadScene("OperationCourse");
                EnableCursor();
                break;
            case BTNType.To_Chaper1_Operation_Course_From_Pause_Button:
                Debug.Log("�Ͻ��������� é�� 1 ���� �帧 â���� �̵�");
                SceneManager.LoadScene("OperationCourseFromPause");
                EnableCursor();
                break;
            case BTNType.Chaper1_Operation_Course_Replay_Button:
                Debug.Log("�Ͻ��������� é�� 1 ���� �帧 â���� �̵�");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                EnableCursor();
                break;
            case BTNType.To_Pause_Button:
                Debug.Log("�Ͻ� ���� â���� �̵�");
                SceneManager.LoadScene("Pause");
                EnableCursor();
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

    public void EnableCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void DisableCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void PreScene()
    {
        preScene = SceneManager.GetActiveScene().name;
    }
}
