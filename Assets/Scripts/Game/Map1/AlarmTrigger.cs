using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmTrigger : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // 碰撞开始
    void OnCollisionEnter2D(Collision2D coll)
    {
        UIManager.Instance.ShowPanel<PhoneAlarmPanel>("Phone/Res/");
    }
    // 碰撞结束
    void OnCollisionExit2D(Collision2D collision)
    {
       // UIManager.Instance.HidePanel<TipPanel>();
    }

    // 碰撞持续中
    void OnCollisionStay(Collision collision)
    {

    }
}
