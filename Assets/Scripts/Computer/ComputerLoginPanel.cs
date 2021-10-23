using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerLoginPanel : BasePanel
{
    public InputField username;
    public InputField password;
    public GameObject error;
    public Button LoginBtn;
    public override void  Init()
    {
        LoginBtn.onClick.AddListener(CheckRight);
    } 
    private void CheckRight()
    {
        if(username.text =="admin"&&password.text=="123456")
        {
            UIManager.Instance.ShowPanel<ComputerMainPanel>("Computer/");
            UIManager.Instance.HidePanel<ComputerLoginPanel>(false);
        } 
        else
        {
            error.SetActive(true);
        }
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
}   
