using UnityEngine;
using System.Collections;
using TMPro;

public class TheWrongEndingSequenceManager : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public AudioSource audio1;

    void Start()
    {
        StartCoroutine(PlaySequence());
    }

    IEnumerator PlaySequence()
    {
        yield return new WaitForSeconds(5f);
        audio1.Play();
        Subtitle.text = "Are you happy now Greg? Are you happy?";

        yield return new WaitForSeconds(6f);
        
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }
}