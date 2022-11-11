using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float _Speed = 4f;
    [SerializeField] float _boostTime = 15f;

    GameManager _gameManager;
    float _playerLife;
    float _boostVertical = 1;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        _gameManager.PlayerDied();
    }

    void Update()
    {
        float yMove = Input.GetAxis("Vertical") * Time.deltaTime * _Speed * _boostVertical;
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * _Speed;
        transform.Translate(xMove, yMove, 0);

        _playerLife += Time.deltaTime;

        if (_playerLife >= _boostTime)
        {
            _boostVertical = _boostVertical + 2;
            _playerLife = 0;
        }
    }


}
