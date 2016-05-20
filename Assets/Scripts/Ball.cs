using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 30;

    public AudioClip BallBounce;

    public AudioClip BallHit;

    private SoundManager soundManager;

    void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RacketLeft")
        {
            HitBall(1, col);
        }
        else if (col.gameObject.name == "RacketRight")
        {
            HitBall(-1, col);
        }
        else
        {
            soundManager.PlayClip(BallBounce);
        }
    }

    private void HitBall(short xDirection, Collision2D racket)
    {
        float factor = HitFactor(transform.position, racket.transform.position, racket.collider.bounds.size.y);
        Vector2 direction = new Vector2(xDirection, factor).normalized;
        Hit(direction);

        soundManager.PlayClip(BallHit);
    }

    private float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    public void Hit(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * Speed;
    }
}
