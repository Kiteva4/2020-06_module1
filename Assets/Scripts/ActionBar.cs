using UnityEngine;

public class ActionBar : MonoBehaviour
{
    [SerializeField] Transform cameraTransform;
    // Start is called before the first frame update
    void Update()
    {
        GetComponent<Transform>().LookAt(cameraTransform);
    }
}
