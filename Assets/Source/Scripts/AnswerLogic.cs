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

    private static int _rightScore;
    private static int _badScore;

    public void CheckAnswer()
    {
        if (_playerAnswer.text.ToLower() == _rightAnswer.ToLower())
        {
            _goodAnswer.SetActive(true);
            _rightScore++;
            if (_badAnswer.activeSelf) _badAnswer.SetActive(false);
            StartCoroutine(_changeScene.StartScene());
        }
        else
        {
            _badAnswer.SetActive(true);
            _badScore++;
            if (_goodAnswer.activeSelf) _goodAnswer.SetActive(false);
            StartCoroutine(_changeScene.StartScene());
        }
    }

    public void AddRightScore()
    {
        _rightScore++;
    }

    public void AddBadScore()
    {
        _badScore++;
    }

    public int GetCurrentScore()
    {
        return _rightScore;
    }

    public int GetBadScore()
    {
        return _badScore;
    }

    public void ResetScores()
    {
        _rightScore = 0;
        _badScore = 0;
    }
}