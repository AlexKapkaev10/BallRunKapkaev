using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float followSpeed;

    [SerializeField]
    private float positionSmoothDamp = 0;

    [SerializeField]
    private Transform target = null;

    [SerializeField]
    private Vector3 positionOfset = Vector3.zero;

    Vector3 targetDampedPosition;
    Vector3 vel;

    private void LateUpdate()
    {
        if(target != null)
        {
            
            targetDampedPosition = Vector3.SmoothDamp(transform.position, target.transform.position + positionOfset, ref vel, positionSmoothDamp);

            targetDampedPosition.x = transform.position.x;
            targetDampedPosition.y = transform.position.y;

            transform.position = targetDampedPosition;
        }
            
    }
}
