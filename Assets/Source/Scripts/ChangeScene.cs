using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private int _idLevel;

    public void StartScene()
    {
        SceneManager.LoadScene(_idLevel);
    }
}
