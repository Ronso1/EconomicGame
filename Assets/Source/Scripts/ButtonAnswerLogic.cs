using UnityEngine;

public class ButtonAnswerLogic : MonoBehaviour
{
    [SerializeField] private ChangeScene _changeScene;
    [SerializeField] private GameObject _resultRight;
    [SerializeField] private GameObject _resultWrong;
    [SerializeField] private bool _isRight;

    public void ButtonClickCheckAnswer()
    {
        var answerCheck = new AnswerLogic();

        if (_isRight)
        {
            _resultRight.SetActive(true);
            if (_resultWrong.activeSelf) _resultWrong.SetActive(false);
            StartCoroutine(_changeScene.StartScene());
            answerCheck.AddRightScore();
        }
        else
        {
            _resultWrong.SetActive(true);
            if (_resultRight.activeSelf) _resultRight.SetActive(false);
            StartCoroutine(_changeScene.StartScene());
            answerCheck.AddBadScore();
        }
    }
}
