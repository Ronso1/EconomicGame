using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultHandler : MonoBehaviour
{
    [SerializeField] private AnswerLogic _answerLogic;
    [Space]
    [SerializeField] private List<GameObject> _pyramids;
    [SerializeField] private List<GameObject> _resultMessage;
    [Space]
    [SerializeField] private TMP_Text _rightAndBadAnswers;

    private int _badAnswersCount, _goodAnswersCount;

    private void Start()
    {
        _goodAnswersCount = _answerLogic.GetCurrentScore();
        _badAnswersCount = _answerLogic.GetBadScore();
        ShowResult();
    }

    private void ShowResult()
    {
        var sumOfCount = _goodAnswersCount + _badAnswersCount;
        float resultPrecent = (_goodAnswersCount / (float)sumOfCount) * 100f;

        if (resultPrecent <= 20f)
        {
            _pyramids[0].SetActive(true);
            _resultMessage[0].SetActive(true);
        }
        else if (resultPrecent > 20f && resultPrecent <= 40f)
        {
            _pyramids[1].SetActive(true);
            _resultMessage[1].SetActive(true);
        }
        else if (resultPrecent > 40f && resultPrecent <= 60f)
        {
            _pyramids[2].SetActive(true);
            _resultMessage[2].SetActive(true);
        }
        else if (resultPrecent > 60f && resultPrecent <= 80f)
        {
            _pyramids[3].SetActive(true);
            _resultMessage[3].SetActive(true);
        }
        else if (resultPrecent > 80f && resultPrecent <= 100f)
        {
            _pyramids[4].SetActive(true);
            _resultMessage[4].SetActive(true);
        }

        _rightAndBadAnswers.text = $"{_goodAnswersCount}/{sumOfCount}";
        _rightAndBadAnswers.gameObject.SetActive(true);
        _answerLogic.ResetScores();
    }
}
