using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public PauseMenuController pauseMenu;

    public void Saludar()
    {
        Debug.Log("Hola desde el botón Saludar");
    }

    public void Volver()
    {
        if (pauseMenu != null)
            pauseMenu.OpenMenu(false);
    }
}
