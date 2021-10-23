using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatFeedPanel : BasePanel
{
    public Image foodOne;
    public Image foodTwo;
    public Image foodThree;
    public Button redBtn;
    public Button blueBtn;
    public Button greenBtn;
    public Button btnReStart;
    public Button btnSure;
    public Text targetText;
    public Text nowText;
    public Text tipText;
    private int num = 0;
  
    private void Sure()
    {
        if (targetText.text == nowText.text)
        {
            tipText.text = "回答正确";
            UIManager.Instance.HidePanel<CatFeedPanel>();
            
            StoryController.Instance.SetNowItem(1, 6);
            MapController.Instance.SetMapOfNowStory();
        }
        else
        {
            tipText.text = "回答错误";

        }
    }
    private void ReStart()
    {
        tipText.text = "";
        num = 0;
        nowText.text = "";
        foodOne.color = new Color(255, 255, 255, 0);
        foodTwo.color = new Color(255, 255, 255, 0);
        foodThree.color = new Color(255, 255, 255, 0);
        foodOne.sprite = null;
        foodTwo.sprite = null;
        foodThree.sprite = null;
    }
    private void FeedRed()
    {
        Feed(0);
    }
    private void FeedBlue()
    {
        Feed(1);
    }
    private void FeedGreen()
    {
        Feed(2);
    }
    private void Feed(int feedNum)
    {

        if (num == 0)
        {
            if (feedNum == 0)
            {

                foodOne.sprite = Resources.Load<Sprite>("猫粮/ml1");
                foodOne.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个红色猫粮";
                nowText.text += "红";
            }
            else if (feedNum == 1)
            {
                foodOne.sprite = Resources.Load<Sprite>("猫粮/ml3");
                foodOne.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个蓝色猫粮";
                nowText.text += "蓝";
            }
            else
            {
                foodOne.sprite = Resources.Load<Sprite>("猫粮/ml2");
                foodOne.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个绿色猫粮";
                nowText.text += "绿";
            }
        }
        else if (num == 1)
        {
            if (feedNum == 0)
            {
                foodTwo.sprite = Resources.Load<Sprite>("猫粮/ml1");
                foodTwo.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个红色猫粮";
                nowText.text += "红";
            }
            else if (feedNum == 1)
            {
                foodTwo.sprite = Resources.Load<Sprite>("猫粮/ml3");
                foodTwo.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个蓝色猫粮";
                nowText.text += "蓝";
            }

            else
            {

                foodTwo.sprite = Resources.Load<Sprite>("猫粮/ml2");
                foodTwo.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个绿色猫粮";
                nowText.text += "绿";
            }
        }
        else if (num == 2)
        {
            if (feedNum == 0)
            {
                foodThree.sprite = Resources.Load<Sprite>("猫粮/ml1");
                foodThree.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个红色猫粮";
                nowText.text += "红";
            }
            else if (feedNum == 1)
            {
                foodThree.sprite = Resources.Load<Sprite>("猫粮/ml3");
                foodThree.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个蓝色猫粮";
                nowText.text += "蓝";
            }
            else
            {
                foodThree.sprite = Resources.Load<Sprite>("猫粮/ml2");
                foodThree.color = new Color(255, 255, 255, 255);
                tipText.text = "添加了一个绿色猫粮";
                nowText.text += "绿";
            }
        }
        else
        {
            tipText.text = "无法投喂";
        }
        if (num < 3)
        {
            num++;
        }
    }

    public override void Init()
    {
        num = 0;
        foodOne.color = new Color(255, 255, 255, 0);
        foodTwo.color = new Color(255, 255, 255, 0);
        foodThree.color = new Color(255, 255, 255, 0);
        foodOne.sprite = null;
        foodTwo.sprite = null;
        foodThree.sprite = null;
        redBtn.onClick.AddListener(FeedRed);
        blueBtn.onClick.AddListener(FeedBlue);
        greenBtn.onClick.AddListener(FeedGreen);
        btnReStart.onClick.AddListener(ReStart);
        btnSure.onClick.AddListener(Sure);
    }
}
