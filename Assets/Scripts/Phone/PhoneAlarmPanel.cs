using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PhoneAlarmPanel : BasePanel
{
    public Image slideMono;
    public Image slideThing;
    private RectTransform slideMonoRectTransform;
    private EventTrigger et;
    public float slideMonoLength=80f;
    public float slideThingLength=400f;

    private void monoDrag(BaseEventData data)
    {
        PointerEventData eventData = data as PointerEventData;
        //跟随拖动的x
        slideMonoRectTransform.position += new Vector3(eventData.delta.x, 0, 0);
        //有专门的参数得到相对于锚点的点
        if(slideMonoRectTransform.anchoredPosition.x>slideThingLength-slideMonoLength || slideMonoRectTransform.anchoredPosition.x<0)
        {
            //拉回来
            if (slideMonoRectTransform.anchoredPosition.x > 0)
                slideMonoRectTransform.anchoredPosition = new Vector3(slideThingLength - slideMonoLength, 0,0);
            else
                slideMonoRectTransform.anchoredPosition = new Vector3(0, 0, 0);

        }
    }
    private void endMonoDrag(BaseEventData data)
    {
        if(slideMonoRectTransform.anchoredPosition.x >= slideThingLength - slideMonoLength)
        {
            UIManager.Instance.HidePanel<BlackPanel>();
            TipController.Instance.SetTipType(2);
            TipController.Instance.SetTip("按TAB展开/收起手机");
            TipController.Instance.action = () =>
              {
                  StoryController.Instance.SetNowItem(1, 2);
                  MapController.Instance.SetMapOfNowStory();
                  TipController.Instance.SetTipType(2);
                  TipController.Instance.SetTip("按AD键左右移动");
                  if (UIManager.Instance.GetPanel<TipPanel>() == null)
                      UIManager.Instance.ShowPanel<TipPanel>();
              };
            if(UIManager.Instance.GetPanel<TipPanel>()==null)
            UIManager.Instance.ShowPanel<TipPanel>();
            UIManager.Instance.HidePanel<PhoneAlarmPanel>();
        }
        //结束拖曳回到源点
        slideMonoRectTransform.anchoredPosition = Vector2.zero;
    }

    public override void Init()
    {

        slideMono.rectTransform.sizeDelta = new Vector2(slideMonoLength, slideMono.rectTransform.sizeDelta.y);
        slideThing.rectTransform.sizeDelta = new Vector2(slideThingLength, slideThing.rectTransform.sizeDelta.y);
        //初始化组件
        slideMonoRectTransform = slideMono.GetComponent<RectTransform>();
        et = slideMono.GetComponent<EventTrigger>();
        //为遥感注册事件
        EventTrigger.Entry en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.Drag;
        en.callback.AddListener(monoDrag);
        et.triggers.Add(en);
        en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.EndDrag;
        en.callback.AddListener(endMonoDrag);
        et.triggers.Add(en);
    }
}   
    
