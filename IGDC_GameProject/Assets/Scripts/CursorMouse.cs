using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cursor = UnityEngine.Cursor;

public class CursorMouse : MonoBehaviour
{
    [SerializeField] Texture2D cursorOrigin;
    void Start()
    {
        Cursor.SetCursor(cursorOrigin, Vector2.zero, CursorMode.ForceSoftware);
    }
    private void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
}
