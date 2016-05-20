using UnityEngine;

public class SideWall : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ball(Clone)")
        {
            gameManager.Score(gameObject.name);
            Destroy(col.gameObject);
        }
    }
}
