using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private int _idLevel;
    [SerializeField] private float _timeDelay;

    public IEnumerator StartScene()
    {
        yield return new WaitForSeconds(_timeDelay);
        SceneManager.LoadScene(_idLevel);
    }
}
