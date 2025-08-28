using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button exitBtn;

    public Button playBtn;

    public Button settingsBtn;

    public Button accountBtn;

    public Button leaderboardBtn;

    public Button iconkitButton;

    private void Awake()
    {
        exitBtn.onClick.AddListener(ExitClick);
        playBtn.onClick.AddListener(PlayClick);
        settingsBtn.onClick.AddListener(SettingsClick);
        accountBtn.onClick.AddListener(AccountClick);
        leaderboardBtn.onClick.AddListener(LeaderboardClick);
        iconkitButton.onClick.AddListener(IconkitClick);
    }

    private void PlayClick()
    {
        SceneManager.LoadScene("Game");
    }

    private void SettingsClick()
    {
        SceneManager.LoadScene("Settings");
    }

    private void AccountClick()
    {
        SceneManager.LoadScene("Account");
    }

    private void LeaderboardClick()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    private void IconkitClick()
    {
        SceneManager.LoadScene("Iconkit");
    }

    private void ExitClick()
    {
        Application.Quit();
    }
}
