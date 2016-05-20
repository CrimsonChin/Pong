using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Ball;

    private ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();

        Vector2 direction = Random.Range(0, 1) > 0.5 ? Vector2.left : Vector2.right;
        ServerBall(direction);
    }

    public void Score(string wallName)
    {
        if (wallName == "WallLeft")
        {
            scoreBoard.ScoreRight();
            ServerBall(Vector2.right);
        }
        else if (wallName == "WallRight")
        {
            scoreBoard.ScoreLeft();
            ServerBall(-Vector2.right);
        }
    } 

    private void ServerBall(Vector2 direction)
    {
        Ball ball = Instantiate(Ball).GetComponent<Ball>();
        ball.Hit(direction);
    }
}
