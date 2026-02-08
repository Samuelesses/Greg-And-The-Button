using UnityEngine;

public class MainButton : MonoBehaviour
{

    private SequenceManager sequenceManager;

    void Start()
    {
        sequenceManager = FindFirstObjectByType<SequenceManager>();
    }

    void OnClicked()
    {
        Debug.Log("Button clicked");
        sequenceManager.OnRedButtonPressed();
    }
}
