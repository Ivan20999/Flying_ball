using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void SceneLoad()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerDied()
    {
        SceneManager.LoadScene(2);
    }

}
