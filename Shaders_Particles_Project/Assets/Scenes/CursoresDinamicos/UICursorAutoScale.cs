using UnityEngine;

public class UICursorAutoScale : MonoBehaviour
{
    public RectTransform cursorRect;
    public Canvas canvas;

    [Header("Size at reference resolution (e.g., 1920x1080)")]
    public Vector2 referenceSize = new Vector2(64, 64);

    [Header("Offset to match hotspot (pixels)")]
    public Vector2 offset = Vector2.zero;

    void Reset()
    {
        cursorRect = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    void OnEnable()
    {
        // Menú: cursor UI visible, cursor sistema oculto
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;

        if (cursorRect == null) cursorRect = GetComponent<RectTransform>();
        if (canvas == null) canvas = GetComponentInParent<Canvas>();
    }

    void Update()
    {
        if (cursorRect == null || canvas == null) return;

        cursorRect.position = (Vector2)Input.mousePosition + offset;

        // Mantener un “tamaño lógico” constante y que el Canvas Scaler lo escale según pantalla
        cursorRect.sizeDelta = referenceSize / canvas.scaleFactor;
    }
}
