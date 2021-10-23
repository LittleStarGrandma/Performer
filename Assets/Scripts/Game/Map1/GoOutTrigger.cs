using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoOutTrigger : MonoBehaviour
{
    private UnityAction action;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        action?.Invoke();
    }
    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            UIManager.Instance.GetPanel<TipPanel>().tip.text = "�ѳ���";
                
        }
    }
    // ��ײ��ʼ
    void OnCollisionEnter2D(Collision2D coll)
    {
        TipController.Instance.SetTipType(1);
        TipController.Instance.SetTip("��E����");
        UIManager.Instance.ShowPanel<TipPanel>();
        action += CheckInput;
    }
    // ��ײ����
    void OnCollisionExit2D(Collision2D collision)
    {
        action = null;
        UIManager.Instance.HidePanel<TipPanel>();
    }

    // ��ײ������
    void OnCollisionStay(Collision collision)
    {

    }
}
