using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
 public float LimitTime;
 public Text text_Timer;

 void Update () {
LimitTime -= Time.deltaTime;
text_Timer.text = "천천히 풀어주기 : " + Mathf.Round(LimitTime);
 }

 }