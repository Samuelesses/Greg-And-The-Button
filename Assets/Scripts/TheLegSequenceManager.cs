using UnityEngine;
using System.Collections;
using TMPro;

public class TheLegSequenceManager : MonoBehaviour
{
    public TextMeshProUGUI Subtitle;
    public AudioSource audio1;
    public AudioSource audio2;

    void Start()
    {
        StartCoroutine(PlaySequence());
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

    }
}