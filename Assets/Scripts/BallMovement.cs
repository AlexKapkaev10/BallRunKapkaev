using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;

    private Vector3 swipeDirection;

    [SerializeField]
    private float correctSwipeDirecton = 0.5f;

    private void Start()
    {
        GameManager.instance.userInput.onHoverTouch += GetDirection;
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(new Vector3(swipeDirection.x * correctSwipeDirecton, 0, speed) * Time.deltaTime);
    }

    private void GetDirection(bool isHold, Vector2 direction)
    {
        swipeDirection = direction;
    }
}
