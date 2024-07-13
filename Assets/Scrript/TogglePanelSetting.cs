using UnityEngine;
using UnityEngine.UI;

public class TogglePanelSetting : MonoBehaviour
{
    public GameObject panel;

    void Start()
    {
        // Đảm bảo panel bắt đầu ẩn
        panel.SetActive(false);
    }

    public void TogglePanelVisibility()
    {
        // Chuyển đổi trạng thái hiển thị của panel
        panel.SetActive(!panel.activeSelf);
    }
}
