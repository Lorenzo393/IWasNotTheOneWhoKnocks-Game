using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private void Start(){
        GameInput.Instance.OnInteract += GameInput_OnInteract;
    }

    private void GameInput_OnInteract(object sender, System.EventArgs e){
        Debug.Log("Interact");
    }
}
