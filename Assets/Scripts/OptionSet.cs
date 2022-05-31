using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionSet : MonoBehaviour
{
    private float SensitiveHor = 5;
    private float SensitiveVer = 3;
    private float SoundEffect = 0.5f;
    private float BackgroundSound = 0.5f;

    public void SetHor(float Hor)
    {
        SensitiveHor = Hor;
    }

    public void SetVer(float Ver)
    {
        SensitiveVer = Ver;
    }

    public void SetSoundEffect(float SE)
    {
        SoundEffect = SE;
    }

    public void SetBackgroundSound(float BS)
    {
        BackgroundSound = BS;
    }

    public void OptionInitialization()
    {
        SensitiveHor = 5;
        SensitiveVer = 3;
        SoundEffect = 0.5f;
        BackgroundSound = 0.5f;
    }
}
