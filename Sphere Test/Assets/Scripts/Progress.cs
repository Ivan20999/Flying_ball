using UnityEngine;

public class Progress : MonoBehaviour
{

    public float _timeLastGame;
    public float _attemptNumber;

    private void Start()
    {
        _attemptNumber = PlayerPrefs.GetFloat("attempt");
        _attemptNumber += 1;
    }

    private void Update()
    {
        _timeLastGame += Time.deltaTime;
    }

    public void SaveData()
    {
        PlayerPrefs.SetFloat("attempt", _attemptNumber);
        PlayerPrefs.SetFloat("timeGame", _timeLastGame);
    }

}
