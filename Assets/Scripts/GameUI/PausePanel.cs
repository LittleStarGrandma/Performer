using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausePanel : BasePanel
{
    public Button continueBtn;
    public Button settingBtn;
    public Button returnBtn;
    public Button exitBtn;
    public override void Init()
    {
        continueBtn.onClick.AddListener(() =>
        {
           
            UIManager.Instance.HidePanel<PausePanel>(false);
        });
        settingBtn.onClick.AddListener(() =>
        {
            UIManager.Instance.ShowPanel<StartSettingPanel>();
        });
        returnBtn.onClick.AddListener(() =>
        {
           
            UIManager.Instance.HidePanel<PausePanel>(false);
            UIManager.Instance.HidePanel<GamePanel>(false);
            SceneManager.LoadScene("LoginSence");
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
