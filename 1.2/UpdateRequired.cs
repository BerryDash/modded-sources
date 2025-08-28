using UnityEngine;
using UnityEngine.UI;

public class UpdateRequired : MonoBehaviour
{
    private void Awake()
    {
        GameObject.Find("Canvas/Button").GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        Application.OpenURL("https://berrydash.lncvrt.xyz/download");
    }
}
