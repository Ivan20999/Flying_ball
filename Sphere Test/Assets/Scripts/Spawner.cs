using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _ball;
    [SerializeField] GameObject _obstacleOnePrefab;
    [SerializeField] GameObject _obstacleTwoPrefab;

    public float _choice�omplexity;
    public float _spawnCycle;

    float _elapsedTime;
    bool _spawnPowerup = true;

    void Start()
    {
        Instantiate(_ball, new Vector3(0, 4, -18), Quaternion.identity);

        _choice�omplexity = PlayerPrefs.GetFloat("complexity");

        switch (_choice�omplexity)
        {
            case 0:
                _spawnCycle = 1f;
                break;
            case 1:
                _spawnCycle = 0.6f;
                break;
            case 2:
                _spawnCycle = 0.2f;
                break;
        }
    }

    void Update()
    {

        _elapsedTime += Time.deltaTime;
        if (_elapsedTime > _spawnCycle)
        {
            GameObject temp;
            if (_spawnPowerup)
                temp = Instantiate(_obstacleOnePrefab) as GameObject;
            else
                temp = Instantiate(_obstacleTwoPrefab) as GameObject;

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3.7f, 3.7f);
            position.y = Random.Range(1.3f, 8.5f);
            temp.transform.position = position;

            _elapsedTime = 0;
            _spawnPowerup = !_spawnPowerup;

        }

    }
}
