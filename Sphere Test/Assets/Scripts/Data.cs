using UnityEngine;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour
{
    public float _timeGame = 0f;
    public float _numberAttempts = 0f;
    public float _speed = 0f;

    private void Start()
    {
   

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            _timeGame = PlayerPrefs.GetFloat("time");
            _numberAttempts = PlayerPrefs.GetFloat("numbers");
            _speed = PlayerPrefs.GetFloat("speed");
           // GetComponent<Progress>()._numberAttempts = _numberAttempts;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            _timeGame = PlayerPrefs.GetFloat("time");
            _numberAttempts = PlayerPrefs.GetFloat("numbers");
        }
    }

  

}
