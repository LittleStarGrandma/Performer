using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CorwdPuzzlePanel : MonoBehaviour
{
    public RectTransform HorizontalRoad;
    public RectTransform mono1;
    public RectTransform mono2;
    public RectTransform mono3;
    public Button reStartBtn;
    public Text text;
    private EventTrigger et1;
    private EventTrigger et2;
    private EventTrigger et3;

    private void monoDrag1(BaseEventData data)
    {
        PointerEventData eventData = data as PointerEventData;
        mono1.position += new Vector3(eventData.delta.x, 0, 0);
        if (mono1.anchoredPosition.x<-443.1)
        {
            mono1.anchoredPosition=new Vector2(-443.1f,mono1.anchoredPosition.y);
        }
        if (mono1.anchoredPosition.x > 443.1)
        {
            mono1.anchoredPosition = new Vector2(443.1f, mono1.anchoredPosition.y);
        }

        mono3.position -= new Vector3(eventData.delta.x, 0, 0);
        if (mono3.anchoredPosition.x < -443.1)
        {
            mono3.anchoredPosition = new Vector2(-443.1f, mono3.anchoredPosition.y);
        }
        if (mono3.anchoredPosition.x > 443.1)
        {
            mono3.anchoredPosition = new Vector2(443.1f, mono3.anchoredPosition.y);
        }
    }
     private void monoDrag2(BaseEventData data)
    {
        PointerEventData eventData = data as PointerEventData;
        mono2.position += new Vector3(eventData.delta.x, 0, 0);

        if (mono2.anchoredPosition.x < -443.1)
        {
            mono2.anchoredPosition = new Vector2(-443.1f, mono2.anchoredPosition.y);
        }
        if (mono2.anchoredPosition.x > 443.1)
        {
            mono2.anchoredPosition = new Vector2(443.1f, mono2.anchoredPosition.y);
        }

        mono1.position += new Vector3(eventData.delta.x, 0, 0);
        if (mono1.anchoredPosition.x < -443.1)
        {
            mono1.anchoredPosition = new Vector2(-443.1f, mono1.anchoredPosition.y);
        }
        if (mono1.anchoredPosition.x > 443.1)
        {
            mono1.anchoredPosition = new Vector2(443.1f, mono1.anchoredPosition.y);
        }

        mono3.position += new Vector3(eventData.delta.x, 0, 0);
        if (mono3.anchoredPosition.x < -443.1)
        {
            mono3.anchoredPosition = new Vector2(-443.1f, mono3.anchoredPosition.y);
        }
        if (mono3.anchoredPosition.x > 443.1)
        {
            mono3.anchoredPosition = new Vector2(443.1f, mono3.anchoredPosition.y);
        }
    }
     private void monoDrag3(BaseEventData data)
    {
        PointerEventData eventData = data as PointerEventData;
        mono3.position += new Vector3(eventData.delta.x, 0, 0);

        if (mono3.anchoredPosition.x < -443.1)
        {
            mono3.anchoredPosition = new Vector2(-443.1f, mono3.anchoredPosition.y);
        }
        if (mono3.anchoredPosition.x > 443.1)
        {
            mono3.anchoredPosition = new Vector2(443.1f, mono3.anchoredPosition.y);
        }

        mono1.position -= new Vector3(eventData.delta.x, 0, 0);
        if (mono1.anchoredPosition.x < -443.1)
        {
            mono1.anchoredPosition = new Vector2(-443.1f, mono1.anchoredPosition.y);
        }
        if (mono1.anchoredPosition.x > 443.1)
        {
            mono1.anchoredPosition = new Vector2(443.1f, mono1.anchoredPosition.y);
        }

    }
    private void ReStart()
    {
        text.gameObject.SetActive(false);
        mono1.anchoredPosition = new Vector2(-443.1f, mono1.anchoredPosition.y);
        mono2.anchoredPosition = new Vector2(443.1f, mono2.anchoredPosition.y);
        mono3.anchoredPosition = new Vector2(-443.1f, mono3.anchoredPosition.y);
    }
    private void Success()
    {
        text.gameObject.SetActive(true);
    }
    private void EndDrag(BaseEventData data)
    {
        print(HorizontalRoad.anchoredPosition);
        print(mono1.anchoredPosition);
        print(mono2.anchoredPosition);
        print(mono3.anchoredPosition);
        if (mono1.anchoredPosition.x>=-31f&&mono1.anchoredPosition.x<=38f)
        {
            if (mono2.anchoredPosition.x >= -31f && mono2.anchoredPosition.x <= 38f)
            {
                if (mono3.anchoredPosition.x >= -31f && mono3.anchoredPosition.x <= 38f)
                {
                    Success();
                }
            }
        }
    }
    void Start()
    {
        reStartBtn.onClick.AddListener(ReStart);
        

        et1 = mono1.GetComponent<EventTrigger>();
        EventTrigger.Entry en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.Drag;
        en.callback.AddListener(monoDrag1);
        et1.triggers.Add(en);
        en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.EndDrag;
        en.callback.AddListener(EndDrag);
        et1.triggers.Add(en);

        et2 = mono2.GetComponent<EventTrigger>();
        en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.Drag;
        en.callback.AddListener(monoDrag2);
        et2.triggers.Add(en);
        en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.EndDrag;
        en.callback.AddListener(EndDrag);
        et2.triggers.Add(en);

        et3 = mono3.GetComponent<EventTrigger>();
        en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.Drag;
        en.callback.AddListener(monoDrag3);
        et3.triggers.Add(en);
        en = new EventTrigger.Entry();
        en.eventID = EventTriggerType.EndDrag;
        en.callback.AddListener(EndDrag);
        et3.triggers.Add(en);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
