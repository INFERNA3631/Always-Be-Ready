using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UITriggerManager : MonoBehaviour
{
    public UIObjectActivate[] UI;
    public CanvasGroup Pause;
    public CanvasGroup Option;
    public Camera cam;



    private int[] TemporaryStorage;

    [SerializeField]
    private GameObject Tourniquet;

    private void OnTriggerEnter(Collider col)
    {
        // 0 : Operation Description
        // 1 : Follow Team
        // 2 : Close To Injured
        // 3 : Injured Condition
        // 4 : Check Self Treatment
        // 5 : Use Tourniquet
        // 6 : Injured To Room

        switch (col.gameObject.tag)
        {
            case "Follow Team":
                Debug.Log("Follow Team");
                UIInitialization();
                UI[0].UIJustShow();
                UI[1].UIJustShow();
                Destroy(col.gameObject);
                break;
            case "Close To Injured":
                Debug.Log("Close To Injured");
                UIInitialization();
                UI[2].UIJustShow();
                Destroy(col.gameObject);
                break;
            case "Check Self Treatment":
                Debug.Log("Check Self Treatment");
                UIInitialization();
                UI[3].UIJustShow();
                UI[4].UIJustShow();
                Destroy(col.gameObject);
                break;
        }
    }



    private void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            ActivePauseUI();
        }



        if (Input.GetKeyDown("t"))
        {
            Debug.Log("지혈대 생성");
            GameObject CloneTourniquet = Instantiate(Tourniquet, new Vector3(transform.position.x, 0f, transform.position.z), Quaternion.identity);
            CloneTourniquet.transform.parent = GameObject.Find("Play").transform;

            Destroy(CloneTourniquet, 60f);
        }
    }

    public void UIInitialization()
    {
        for (int i = 0; i < UI.Length; i++)
        {
            UI[i].UIOFF();
        }
    }

    public void UITemporaryStorage()
    {
        TemporaryStorage = new int[UI.Length];

        for (int i = 0; i < UI.Length; i++)
        {
            if (UI[i].canvasGroup.alpha == 1)
            {
                if (UI[i].canvasGroup.blocksRaycasts)
                {
                    TemporaryStorage[i] = 0;
                }
                else
                {
                    TemporaryStorage[i] = 1;
                }
            }
            else
            {
                TemporaryStorage[i] = 2;
            }
        }

        UIInitialization();
    }

    public void UIReapply()
    {
        for (int i = 0; i < UI.Length; i++)
        {
            switch (TemporaryStorage[i])
            {
                case 0:
                    UI[i].UIInteraction();
                    break;
                case 1:
                    UI[i].UIJustShow();
                    break;
                case 2:
                    UI[i].UIOFF();
                    break;
            }
        }
    }

    public void ActivePauseUI()
    {
        if (SceneManager.GetActiveScene().name == "Operation")
        {
            if (Pause.alpha == 1)
            {
                Debug.Log("미션으로 이동");
                UIReapply();
                Pause.alpha = 0;
                Pause.blocksRaycasts = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else if (Pause.alpha == 0)
            {
                if (Option.alpha == 0)
                {
                    Debug.Log("일시 정지 창으로 이동");
                    UITemporaryStorage();
                    Pause.alpha = 1;
                    Pause.blocksRaycasts = true;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
            }
        }
    }
}
