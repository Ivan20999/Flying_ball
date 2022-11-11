using UnityEngine;

public class TextureScroller : MonoBehaviour
{

    [SerializeField] GameObject _ground;
    [SerializeField] GameObject _ceiling;
    [SerializeField] GameObject _leftWall;
    [SerializeField] GameObject _rightWall;

    public float _choice—omplexity;
    public float _speed;

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

        _choice—omplexity = PlayerPrefs.GetFloat("complexity");

        switch (_choice—omplexity)
        {
            case 0:
                _speed = 0.5f;
                break;
            case 1:
                _speed = 1f;
                break;
            case 2:
                _speed = 2f;
                break;
        }
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
