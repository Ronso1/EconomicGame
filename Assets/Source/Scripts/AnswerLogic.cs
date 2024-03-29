using TMPro;
using UnityEngine;

public class AnswerLogic : MonoBehaviour
{
    [SerializeField] private ChangeScene _changeScene;
    [SerializeField] private TMP_InputField _playerAnswer;
    [SerializeField] private GameObject _goodAnswer;
    [SerializeField] private GameObject _badAnswer;
    [Space]
    [SerializeField] private string _rightAnswer;

    public void CheckAnswer()
    {
        if (_playerAnswer.text.ToLower() == _rightAnswer.ToLower())
        {
            _goodAnswer.SetActive(true);
            if (_badAnswer.activeSelf) _badAnswer.SetActive(false);
            StartCoroutine(_changeScene.StartScene());
        }
        else
        {
            _badAnswer.SetActive(true);

            if (_goodAnswer.activeSelf) _goodAnswer.SetActive(false);
        }
    }
}