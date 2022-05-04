using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementCharacterController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed; // 이동 속도
    private Vector3 moveForce; // 이동 합

    [SerializeField]
    private float gravity;

    private CharacterController characterController; // 플레이어 이동 제어를 위한 컴포넌트

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveForce.y -= gravity * Time.deltaTime;

        characterController.Move(moveForce * Time.deltaTime);
    }

    public void MoveTo(Vector3 direction)
    {
        // 이동 방향 = 캐릭터의 회전 값 * 방향 값
        direction = transform.rotation * new Vector3(direction.x, 0, direction.z);

        // 이동 합 = 이동 방향 * 속도
        moveForce = new Vector3(direction.x * moveSpeed, 0, direction.z * moveSpeed);
    }
}
