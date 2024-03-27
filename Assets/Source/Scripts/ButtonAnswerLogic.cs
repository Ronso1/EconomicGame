using UnityEngine;

public class ButtonAnswerLogic : MonoBehaviour
{
    [SerializeField] private GameObject _resultRight;
    [SerializeField] private GameObject _resultWrong;
    [SerializeField] private bool _isRight;

    public void ButtonClickCheckAnswer()
    {
        if (_isRight)
        {
            _resultRight.SetActive(true);
            if (_resultWrong.activeSelf) _resultWrong.SetActive(false);
        }
        else
        {
            _resultWrong.SetActive(true);
            if (_resultRight.activeSelf) _resultRight.SetActive(false);
        }
    }
}
