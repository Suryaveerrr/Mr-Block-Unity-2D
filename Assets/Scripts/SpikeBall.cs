using UnityEngine;

public class SpikeBall : MonoBehaviour
{
    public float RotationAngle = 90.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateSpikeBall();
    }

    private void RotateSpikeBall()
    {
        transform.Rotate(Vector3.forward, RotationAngle * Time.deltaTime);
    }
}
