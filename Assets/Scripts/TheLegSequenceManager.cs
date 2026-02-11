using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class TheLegSequenceManager : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public AudioSource audio1;
    public AudioSource audio2;
    private ProgressManager progressManager;

    void Start()
    {
        StartCoroutine(PlaySequence());
        progressManager = Object.FindFirstObjectByType<ProgressManager>();
    }

    IEnumerator PlaySequence()
    {
        yield return new WaitForSeconds(5f);
        audio1.Play();
        Subtitle.text = "You like it now Greg? I've had to put you into an insane asylum.";

        yield return new WaitForSeconds(10f);
        audio2.Play();
        Subtitle.text = "Greg, are you looking for a button? You're out of your mind,";

        yield return new WaitForSeconds(5f);
        Subtitle.text = "is this all you think of doing now? Fine, ill send you back.";

        yield return new WaitForSeconds(6f);
        progressManager.CompleteEnding("The Leg Ending");
        
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Home");

    }
}