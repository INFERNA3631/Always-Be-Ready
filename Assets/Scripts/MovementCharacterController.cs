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

    private CharacterController characterController; // �÷��̾� �̵� ��� ���� ������Ʈ

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Operation")
        {
            moveForce.y -= gravity * Time.deltaTime;

            characterController.Move(moveForce * Time.deltaTime);
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
