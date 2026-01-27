using UnityEngine;

public class SystemCursorAutoScale : MonoBehaviour
{
    [Header("Cursor textures (same design, different sizes)")]
    public Texture2D cursor32;
    public Texture2D cursor64;
    public Texture2D cursor128;

    [Header("Hotspot (pixels)")]
    public Vector2 hotspot = Vector2.zero;

    [Header("Screen width thresholds")]
    public int use64FromWidth = 1200;
    public int use128FromWidth = 2200;

    int lastWidth;

    void Start()
    {
        ApplyCursor();
        lastWidth = Screen.width;
    }

    void Update()
    {
        // Si cambia resolución / fullscreen
        if (Screen.width != lastWidth)
        {
            lastWidth = Screen.width;
            ApplyCursor();
        }
    }

    void ApplyCursor()
    {
        Texture2D selected = cursor32;

        if (Screen.width >= use128FromWidth && cursor128 != null)
            selected = cursor128;
        else if (Screen.width >= use64FromWidth && cursor64 != null)
            selected = cursor64;

        Cursor.SetCursor(selected, hotspot, CursorMode.Auto);
    }

    public void ClearCursor()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
