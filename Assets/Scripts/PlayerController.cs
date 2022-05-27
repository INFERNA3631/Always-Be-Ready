using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip audioClipWalk;

    private MouseManager                   rotateToMouse; // 마우스 이동으로 카메라 회전
    private MovementCharacterController     movement; // 키보드 입력으로 플레이어 이동
    private AudioSource                     audioSource; // 사운드 재생 제어

    void Awake()
    {
        rotateToMouse       = GetComponent<MouseManager>();
        movement            = GetComponent<MovementCharacterController>();
        audioSource         = GetComponent<AudioSource>();

        transform.Rotate(0, 0, 180);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRotate();
        UpdateMove();
    }

    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");

        rotateToMouse.UpdateRotate(mouseX, 0);
    }

    private void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        //if (x != 0 || z != 0)
        //{
        //    if (audioSource.isPlaying == false)
        //    {
        //        audioSource.loop = true;
        //        audioSource.Play();
        //    }
        //}
        //else
        //{
        //    if (audioSource.isPlaying == true)
        //    {
        //        audioSource.Stop();
        //    }
        //}

        movement.MoveTo(new Vector3(x, 0, z));
    }
}
