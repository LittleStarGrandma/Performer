using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ComputerTrigger : MonoBehaviour
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
            if (UIManager.Instance.GetPanel<ComputerLoginPanel>() == null)
                UIManager.Instance.ShowPanel<ComputerLoginPanel>("Computer/");
        }
    }
    // 碰撞开始
    void OnCollisionEnter2D(Collision2D coll)
    {
        TipController.Instance.SetTipType(2);
        TipController.Instance.SetTip("按E打开电脑");
        UIManager.Instance.ShowPanel<TipPanel>();
        action += CheckInput;
    }
    // 碰撞结束
    void OnCollisionExit2D(Collision2D collision)
    {
        action = null;

    }

    // 碰撞持续中
    void OnCollisionStay(Collision collision)
    {

    }
}
