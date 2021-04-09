using UnityEngine;
using UnityEngine.Events;

public class UserInput : MonoBehaviour
{
    public UnityAction<bool, Vector2> onHoverTouch;

    Vector2 joystickLastInputPosition;

    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (onHoverTouch != null) HoverTouch();
    }

    private void HoverTouch()
    {
        Camera main_cam = Camera.main;

        if (Input.GetMouseButtonDown(0))
        {
            joystickLastInputPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 joystickNextInputPosition = Input.mousePosition;

            Vector2 direction = joystickNextInputPosition - joystickLastInputPosition;

            onHoverTouch?.Invoke(true, direction);

            joystickLastInputPosition = joystickNextInputPosition;
        }
        else
        {
            onHoverTouch?.Invoke(false, Vector2.zero);
        }
    }

    public void ClearAllEvents()
    {
        onHoverTouch = null;
    }
}
