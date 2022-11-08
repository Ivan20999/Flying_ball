using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    [SerializeField] float _speed = 0.5f;
    [SerializeField] GameObject _ground;
    [SerializeField] GameObject _ceiling;
    [SerializeField] GameObject _leftWall;
    [SerializeField] GameObject _rightWall;

    Renderer _rendererGround;
    Renderer _rendererCeiling;
    Renderer _rendererLeftWal;
    Renderer _rendererRightWall;

    float offset = 1.0f;

    void Start()
    {
        _rendererGround = _ground.GetComponent<Renderer>();
        _rendererCeiling = _ceiling.GetComponent<Renderer>();
        _rendererLeftWal = _leftWall.GetComponent<Renderer>();
        _rendererRightWall = _rightWall.GetComponent<Renderer>();
    }

    private void Update()
    {
        offset -= Time.deltaTime * _speed;
        if (offset <= 0)
            offset += 1;

        _rendererGround.material.mainTextureOffset = new Vector2(offset, 0);
        _rendererCeiling.material.mainTextureOffset = new Vector2(offset, 0);
        _rendererLeftWal.material.mainTextureOffset = new Vector2(offset, 0);
        _rendererRightWall.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
