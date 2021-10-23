using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;

public class SwapClothingTrigger : MonoBehaviour
{
    private UnityAction action;
    public SpriteRenderer player;
    void Start()
    {

    }
    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //����ͼ�� ע�⣺��Ҫ���������ռ�
            Sprite[] gameobj = Resources.LoadAll<Sprite>("Player/Player");
            //��ͼ���м���ָ�����ֵ�Сͼ

            player.sprite = gameobj[4];
            StoryController.Instance.SetNowItem(1, 4);
            MapController.Instance.SetMapOfNowStory();
        }
    }
    // Update is called once per frame
    void Update()
    {
        action?.Invoke();
    }
    // ��ײ��ʼ
    void OnCollisionEnter2D(Collision2D coll)
    {
        TipController.Instance.SetTipType(2);
        TipController.Instance.SetTip("��E��װ");
        UIManager.Instance.ShowPanel<TipPanel>();
        action += CheckInput;
    }
    // ��ײ����
    void OnCollisionExit2D(Collision2D collision)
    {
        // UIManager.Instance.HidePanel<TipPanel>();
        action -= CheckInput;
    }

    // ��ײ������
    void OnCollisionStay(Collision collision)
    {
        
    }
}
