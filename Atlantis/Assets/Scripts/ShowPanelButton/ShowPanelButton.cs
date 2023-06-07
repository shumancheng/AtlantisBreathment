using UnityEngine;
using UnityEngine.UI;

public class ShowPanelButton : MonoBehaviour
{
    public GameObject panel;
    public Button button;

    public void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(TogglePanelVisibility);
        panel.SetActive(false);
    }

    public void TogglePanelVisibility()
    {
        Debug.Log("TogglePanelVisibility method called");
        panel.SetActive(!panel.activeSelf);
    }
}
