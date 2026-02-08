using UnityEngine;

public class GreenButton : MonoBehaviour
{

    private SequenceManager sequenceManager;

    void Start()
    {
        sequenceManager = FindFirstObjectByType<SequenceManager>();
    }

    void OnClicked()
    {
        Debug.Log("Green Button clicked");
        sequenceManager.OnGreenButtonPressed();
    }
}
