using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
   
    // Start is called before the first frame update
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
        UIManager.Instance.ShowPanel<TipPanel>();  
    }
    // ��ײ����
    void OnCollisionExit2D(Collision2D collision)
    {
        UIManager.Instance.HidePanel<TipPanel>();
    }

    // ��ײ������
   void OnCollisionStay(Collision collision)
    {

    }
}
