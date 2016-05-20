using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float Speed = 30;
    public string Axis = "Vertical";
        
    void FixedUpdate()
    {
        float inputAxis = Input.GetAxisRaw(Axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, inputAxis) * Speed;
    }
}
