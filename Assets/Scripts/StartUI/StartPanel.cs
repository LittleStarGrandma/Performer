using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartPanel : BasePanel
{
    public Button startBtn;
    public Button settingBtn;
    public Button exitBtn;
    public override void Init()
    {
        startBtn.onClick.AddListener(() =>
        {
            UIManager.Instance.HidePanel<StartPanel>(false);
            UIManager.Instance.ShowPanel<BlackPanel>();
            UIManager.Instance.ShowPanel<GamePanel>();
            StoryController.Instance.SetNowItem(1, 1);
          
            SceneManager.LoadScene("GameSence");
        });
        settingBtn.onClick.AddListener(() =>
        {
            UIManager.Instance.ShowPanel<StartSettingPanel>();
            
        });
        exitBtn.onClick.AddListener(() =>
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        });
    }
}
