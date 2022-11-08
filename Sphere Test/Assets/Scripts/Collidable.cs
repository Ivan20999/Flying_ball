using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{

    GameManager _manager;
    public float _moveSpeed = 20f;
    public float _timeAmount = 1.5f;

    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(0, 0, -_moveSpeed * Time.deltaTime,Space.World);
        _manager = FindObjectOfType<GameManager>();

        Destroy(gameObject, 12);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
