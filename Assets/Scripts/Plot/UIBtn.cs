using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBtn : MonoBehaviour
{
    public InputField ipf;
    public GameObject plotPanel;
    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(
            ()=>
            {
                plotPanel.GetComponent<PlotPanel>().plotItems = PlotController.Instance.ReceivePlotsById(int.Parse(ipf.text));
                plotPanel.SetActive(false);
                plotPanel.SetActive(true);
                
            }
            );
    }
}
