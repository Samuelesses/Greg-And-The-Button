using UnityEngine;
using System.Collections;
using TMPro;

public class TheWrongEndingSequenceManager : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    private ProgressManager progressManager;
    public AudioSource audio1;

    void Start()
    {
        StartCoroutine(PlaySequence());
        progressManager = Object.FindFirstObjectByType<ProgressManager>();
    }

    IEnumerator PlaySequence()
    {
        yield return new WaitForSeconds(5f);
        audio1.Play();
        Subtitle.text = "Are you happy now Greg? Are you happy?";

        yield return new WaitForSeconds(6f);
        progressManager.CompleteEnding("The Wrong Ending");
        
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }
}