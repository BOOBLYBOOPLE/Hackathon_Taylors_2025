using UnityEngine;
using UnityEngine.SceneManagement; // 引入场景系统

public class PanelManager : MonoBehaviour
{
    public GameObject[] allPanels;    // 8个 Panel
    public GameObject page1Buttons;   // Page1 所有按钮合集

    // 显示某个 Panel，隐藏其它面板 + Page1 按钮
    public void ShowPanel(GameObject panelToShow)
    {
        foreach (GameObject panel in allPanels)
        {
            panel.SetActive(false);
        }

        panelToShow.SetActive(true);
        page1Buttons.SetActive(false);
    }

     public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}