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
    // ��ײ��ʼ
    void OnCollisionEnter2D(Collision2D coll)
    {
        UIManager.Instance.ShowPanel<PhoneAlarmPanel>("Phone/Res/");
    }
    // ��ײ����
    void OnCollisionExit2D(Collision2D collision)
    {
       // UIManager.Instance.HidePanel<TipPanel>();
    }

    // ��ײ������
    void OnCollisionStay(Collision collision)
    {

    }
}
