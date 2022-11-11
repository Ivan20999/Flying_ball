using UnityEngine;

public class Player : MonoBehaviour
{

    public float _Speed = 4f;
    public float _boostTime = 15f;
    public float _choice—omplexity;

    float _playerLife;
    float _boostVertical = 1;
    float yMove;
    float xMove;

    GameObject _gameManager;

    private void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameController");
        _choice—omplexity = PlayerPrefs.GetFloat("complexity");
    }

    public void OnTriggerEnter(Collider other)
    {
        _gameManager.GetComponent<GameManager>().PlayerDied();
        _gameManager.GetComponent<Progress>().SaveData();
    }

    void Update()
    {
        xMove = Input.GetAxis("Horizontal") * Time.deltaTime * _Speed;
        yMove = Input.GetAxis("Vertical") * Time.deltaTime * _Speed * _boostVertical;

        switch (_choice—omplexity)
        {
            case 0:
                xMove = 0f;
                yMove = Mathf.Clamp(yMove + yMove, 0, 1);
                break;
            case 1:
                xMove = 0f;
                yMove = Mathf.Clamp(yMove + yMove, 0, 1);
                break;
            case 2:
                xMove += xMove;
                yMove += yMove;
                break;
        }

        transform.Translate(xMove, yMove, 0);

        _playerLife += Time.deltaTime;

        if (_playerLife >= _boostTime)
        {
            _boostVertical = _boostVertical + 2;
            _playerLife = 0;
        }
    }


}
