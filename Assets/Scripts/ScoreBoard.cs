using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public Text ScoreLeftText;

    public Text ScoreRightText;

    private int scoreLeft = 0;

    private int scoreRight = 0;

    public void ScoreLeft()
    {
        scoreLeft++;
        ScoreLeftText.text = scoreLeft > 9 ? scoreLeft.ToString() : "0" + scoreLeft;
    }

    public void ScoreRight()
    {
        scoreRight++;
        ScoreRightText.text = scoreRight > 9 ? scoreRight.ToString() : "0" + scoreRight;
    }
}
