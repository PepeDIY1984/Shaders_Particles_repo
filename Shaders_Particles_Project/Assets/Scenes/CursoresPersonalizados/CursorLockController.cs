using StarterAssets;
using UnityEngine;

public class CursorLockController : MonoBehaviour
{
    public GameObject canvasMenu;
    public FirstPersonController firstPersonController;

    void Update()
    {
        // Presionar ESC para liberar el cursor
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            firstPersonController.enabled = false;
            canvasMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
