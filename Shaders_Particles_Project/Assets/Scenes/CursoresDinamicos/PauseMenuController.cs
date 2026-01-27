using StarterAssets;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [Header("References")]
    public GameObject canvasMenu;
    public FirstPersonController firstPersonController;
    public GameObject uiCursorObject; // el GameObject del cursor UI (Image)

    bool isMenuOpen;

    void Start()
    {
        OpenMenu(false);

        // Gameplay inicial
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (firstPersonController != null)
            firstPersonController.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenMenu(!isMenuOpen);
        }
    }

    public void OpenMenu(bool open)
    {
        isMenuOpen = open;

        if (canvasMenu != null) canvasMenu.SetActive(open);
        if (uiCursorObject != null) uiCursorObject.SetActive(open);

        if (firstPersonController != null)
            firstPersonController.enabled = !open;

        if (!open)
        {
            // Volver a FPS
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            // Menú (el cursor UI se encargará de lockState/visible en OnEnable,
            // pero lo dejamos consistente)
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }
    }

    public bool IsMenuOpen() => isMenuOpen;
}
