using UnityEngine;

public class Collidable : MonoBehaviour
{

    public float _moveSpeed;
    public float _timeAmount = 1.5f;
    public float _choice—omplexity;

    private void Start()
    {
        _choice—omplexity = PlayerPrefs.GetFloat("complexity");

        switch (_choice—omplexity)
        {
            case 0:
                _moveSpeed = 5f;
                break;
            case 1:
                _moveSpeed = 10f;
                break;
            case 2:
                _moveSpeed = 20f;
                break;
        }
    }

    void Update()
    {
        transform.Translate(0, 0, -_moveSpeed * Time.deltaTime, Space.World);
        Destroy(gameObject, 12);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
