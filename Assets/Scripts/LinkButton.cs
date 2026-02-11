using UnityEngine;
using UnityEngine.SceneManagement;

public class LinkButton : MonoBehaviour
{
    public string link;
    void OnClicked()
    {
        Application.OpenURL(link);
    }
}
