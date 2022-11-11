using TMPro;
using UnityEngine;

public class ProgressText : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _timeTextMeaning;
    [SerializeField] TextMeshProUGUI _attemptTextMeaning;

    void Start()
    {
        _timeTextMeaning.text = Mathf.Floor(PlayerPrefs.GetFloat("timeGame")).ToString();
        _attemptTextMeaning.text = PlayerPrefs.GetFloat("attempt").ToString();
    }

}
