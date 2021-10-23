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
            //加载图集 注意：需要引用命名空间
            Sprite[] gameobj = Resources.LoadAll<Sprite>("Player/Player");
            //从图集中加载指定名字的小图

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
    // 碰撞开始
    void OnCollisionEnter2D(Collision2D coll)
    {
        TipController.Instance.SetTipType(2);
        TipController.Instance.SetTip("按E换装");
        UIManager.Instance.ShowPanel<TipPanel>();
        action += CheckInput;
    }
    // 碰撞结束
    void OnCollisionExit2D(Collision2D collision)
    {
        // UIManager.Instance.HidePanel<TipPanel>();
        action -= CheckInput;
    }

    // 碰撞持续中
    void OnCollisionStay(Collision collision)
    {
        
    }
}
