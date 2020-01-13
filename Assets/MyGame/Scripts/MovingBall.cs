using UnityEngine;

public class MovingBall : MonoBehaviour
{
    public Transform[] positions;
    public Transform ball;

    public void RandomBallPosition()
    {
        ball.position = positions[Random.Range(0, positions.Length)].position;
    }
}