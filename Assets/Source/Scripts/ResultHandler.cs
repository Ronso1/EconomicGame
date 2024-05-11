using UnityEngine;

public class ResultHandler : MonoBehaviour
{
    [SerializeField] private AnswerLogic _answerLogic;

    private int _badAnswersCount, _goodAnswersCount;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _goodAnswersCount = _answerLogic.GetCurrentScore();
            _badAnswersCount = _answerLogic.GetBadScore();
            print(_goodAnswersCount);
            print(_badAnswersCount);
        }
    }
}
