using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlotPanel : MonoBehaviour
{

    public Button skipBtn;
    public Button NextBtn;
    public Text content;
    public Image leftImage;
    public Image rightImage;
    //public GameObject initPanel;
    public List<PlotItem> plotItems;
    private int nowIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        skipBtn.onClick.AddListener(EndPlot);
        NextBtn.onClick.AddListener(() =>
        {
            if(nowIndex>=plotItems.Count-1)
            {
                EndPlot();
               
            }
            else
            {
                nowIndex++;
                Refresh();
            }

        });

    }
    private void OnEnable()
    {
        this.nowIndex = 0;
        Refresh();
    }
    private void EndPlot()
    {
        this.nowIndex = 0;
        this.transform.gameObject.SetActive(false);
        //initPanel.gameObject.SetActive(true);
    }

    private void Refresh()
    {
        
        PlotItem temp = plotItems[nowIndex];
        content.text = temp.content;
        if(temp.leftImageExsit)
        {
            leftImage.sprite = Resources.Load<Sprite>(temp.leftImagePath);
            leftImage.color = new Color(255,255,255,255.0f);
        }
        else
        {
            leftImage.color = new Color(255, 255, 255, 0);
        }

        if (temp.rightImageExsit)
        {
            rightImage.sprite = Resources.Load<Sprite>(temp.rightImagePath);
            rightImage.color = new Color(255, 255, 255, 255.0f);
        }
        else
        {
            rightImage.color = new Color(255, 255, 255, 0);
        }
    }
    
    
}
