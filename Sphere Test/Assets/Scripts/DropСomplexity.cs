using TMPro;
using UnityEngine;

public class Drop—omplexity : MonoBehaviour
{

    [SerializeField] TMP_Dropdown _dropdown;

    public float _speedGame;

    private void Start()
    {
        SetComplexity();
    }

    public void SetComplexity()
    {
        switch (_dropdown.value)
        {
            case 0:
                _speedGame = 1.0f;
                break;
            case 1:
                _speedGame = 4.0f;
                break;
            case 2:
                _speedGame = 8.0f;
                break;
        }

        PlayerPrefs.SetFloat("speed", _speedGame);
    }
}
