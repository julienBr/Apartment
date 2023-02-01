using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    private void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit, 1.5f))
        {
            if(hit.collider.GetComponent<IUsable>() != null && Input.GetKeyDown(KeyCode.E)) hit.collider.GetComponent<IUsable>().UseObject();
        }
    }
}