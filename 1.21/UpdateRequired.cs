using UnityEngine;
using UnityEngine.UI;

public class UpdateRequired : MonoBehaviour
{
    public Button btn;

    private void Awake()
    {
        btn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        Application.OpenURL("https://berrydash.lncvrt.xyz/download");
    }
}
