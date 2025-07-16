using UnityEngine;

public class Patroling_SpikeBall : MonoBehaviour
{
    public float RotationAngle = 90.0f;
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    private Vector3 target;

    void Start()
    {
        // Start by moving towards point B
        
            target = pointB.position;
    }

    void Update()
    {
        RotateSpikeBall();
        MoveSpikeBall();
    }

    private void RotateSpikeBall()
    {
        transform.Rotate(Vector3.forward, RotationAngle * Time.deltaTime);
    }

    private void MoveSpikeBall()
    {
        if (pointA == null || pointB == null) return;

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // If reached the target, switch direction
        if (Vector3.Distance(transform.position, target) < 0.05f)
        {
            target = (target == pointA.position) ? pointB.position : pointA.position;
        }
    }
}
