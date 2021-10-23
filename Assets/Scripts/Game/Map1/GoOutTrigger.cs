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
            UIManager.Instance.GetPanel<TipPanel>().tip.text = "已出门";
                
        }
    }
    // 碰撞开始
    void OnCollisionEnter2D(Collision2D coll)
    {
        TipController.Instance.SetTipType(1);
        TipController.Instance.SetTip("按E出门");
        UIManager.Instance.ShowPanel<TipPanel>();
        action += CheckInput;
    }
    // 碰撞结束
    void OnCollisionExit2D(Collision2D collision)
    {
        action = null;
        UIManager.Instance.HidePanel<TipPanel>();
    }

    // 碰撞持续中
    void OnCollisionStay(Collision collision)
    {

    }
}
