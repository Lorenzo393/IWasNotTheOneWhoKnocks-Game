using System.Xml.Serialization;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    public static CursorLock Instance {get; private set;}

    private void Awake(){
        Instance = this;
    }
    private void Start(){
        CursorDisable();
    }

    public void CursorEnable(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void CursorDisable(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
