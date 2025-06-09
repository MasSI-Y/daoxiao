using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("EndScene"); // 直接跳转到结束页面
    }

    public void OpenSettings()
    {
        Debug.Log("设置界面（暂未实现）");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("退出游戏");
    }
}
