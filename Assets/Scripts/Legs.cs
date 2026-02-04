using Unity.Mathematics;
using UnityEngine;

public class Legs : MonoBehaviour
{
    [Range(0.7f, 1f)]
    public float threshold = 0.9f;

    void Update()
    {
        float currentX = transform.eulerAngles.x;

        if (Mathf.Abs(currentX - 90f) < 1f)
        {
            Debug.Log("cam done it");
        }
    }
}
