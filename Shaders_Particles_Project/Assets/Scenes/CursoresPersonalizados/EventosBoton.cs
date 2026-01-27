using StarterAssets;
using UnityEngine;

public class EventosBoton : MonoBehaviour
{
    public GameObject canvasMenu;
    public FirstPersonController firstPersonController;

    public void Saludar()
    {
        Debug.Log("hola desde el botón");
    }

    public void Volver()
    {
        firstPersonController.enabled = true;
        canvasMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
