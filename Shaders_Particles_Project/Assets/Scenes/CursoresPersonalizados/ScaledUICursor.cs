using UnityEngine;

public class ScaledUICursor : MonoBehaviour
{
    [Header("Cursor UI")]
    public RectTransform cursor;

    [Header("Reference (same as Canvas Scaler)")]
    public Vector2 referenceResolution = new Vector2(1920, 1080);

    [Header("Cursor size at reference resolution")]
    public Vector2 baseSize = new Vector2(64, 64);

    [Header("Extra fine tuning")]
    public float sizeMultiplier = 1f;

    [Header("Hotspot offset (pixels)")]
    public Vector2 offset = Vector2.zero;

    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.None;

        UpdateSize();
    }

    void Update()
    {
        cursor.position = (Vector2)Input.mousePosition + offset;

        // Si cambia resolución o fullscreen
        //UpdateSize();
    }

    void UpdateSize()
    {
        // Escala proporcional (pantalla pequeña → pequeño)
        float scaleX = Screen.width / referenceResolution.x;
        float scaleY = Screen.height / referenceResolution.y;

        // Usamos el menor para no deformar
        float scale = Mathf.Min(scaleX, scaleY) * sizeMultiplier;

        cursor.sizeDelta = baseSize * scale;
    }

    void OnDisable()
    {
        Cursor.visible = true;
    }
}
