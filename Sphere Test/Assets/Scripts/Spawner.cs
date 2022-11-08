using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _ball;
    [SerializeField] GameObject _obstacleOnePrefab;
    [SerializeField] GameObject _obstacleTwoPrefab;
    [SerializeField] float _spawnCycle = 0.5f;

    GameManager _manager;

    float _elapsedTime;
    bool _spawnPowerup = true;

    // Start is called before the first frame update
    void Start()
    {
        BallSpawn();
    }

    public void BallSpawn()
    {
        Instantiate(_ball, new Vector3(0,4,-18) , Quaternion.identity);
    }

    // Update is called once per frame
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
