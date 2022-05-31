using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(CharacterController))]
public class MovementCharacterController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed; // �̵� �ӵ�
    private Vector3 moveForce; // �̵� ��

    [SerializeField]
    private float gravity;

    public CanvasGroup Option;
    public CanvasGroup Pause;

    private CharacterController characterController; // �÷��̾� �̵� ��� ���� ������Ʈ

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Operation")
        {
            if (Option.alpha == 0 && Pause.alpha == 0)
            {
                moveForce.y -= gravity * Time.deltaTime;

                characterController.Move(moveForce * Time.deltaTime);
            }
        }
    }


    public void MoveTo(Vector3 direction)
    {
        // �̵� ���� = ĳ������ ȸ�� �� * ���� ��
        direction = transform.rotation * new Vector3(direction.x, 0, direction.z);

        // �̵� �� = �̵� ���� * �ӵ�
        moveForce = new Vector3(direction.x * moveSpeed, 0, direction.z * moveSpeed);
    }
}
