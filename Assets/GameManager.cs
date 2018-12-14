using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded = false;
    public float _restartDelay = 2f;

    public void EndGame()
    {
        if (!_gameHasEnded)
        {
            _gameHasEnded = true;
            Debug.Log("//// GAME_OVER ////");
            Invoke("Restart", _restartDelay);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
