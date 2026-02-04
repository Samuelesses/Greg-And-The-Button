using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public float interactDistance = 5f;
    public LayerMask interactLayer;

    Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
            {
                hit.collider.SendMessage("OnClicked", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
