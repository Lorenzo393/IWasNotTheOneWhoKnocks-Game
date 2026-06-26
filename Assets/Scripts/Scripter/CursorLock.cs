using UnityEngine;

public class CursorLock : MonoBehaviour
{
    public static CursorLock Instance {get; private set;}
    private void OnEnable(){
        Instance = this;

        BlockCursor();
    }

    public void BlockCursor(){
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void EnableCursor(){
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
