using TMPro;
using UnityEngine;

public class Drop—omplexity : MonoBehaviour
{

    [SerializeField] TMP_Dropdown _dropdown;

    public float _choice—omplexity;

    private void Start()
    {
        SetComplexity();
    }

    public void SetComplexity()
    {
        PlayerPrefs.SetFloat("complexity", _dropdown.value);
    }
}
