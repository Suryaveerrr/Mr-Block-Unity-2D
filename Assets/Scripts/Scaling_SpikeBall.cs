using UnityEngine;

public class Scaling_SpikeBall : MonoBehaviour
{
    public float RotationAngle = 90.0f;
    public float scalingSpeed = 15.0f;
    public float minScale = 0.5f;
    public float maxScale = 1.5f;
    public float scalingFactor;
    public float currentScale;
    public float scaleDelay = 2.0f;
    public float timer = 0f;
    private bool isWaiting = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentScale = minScale;
        ApplyCurrentScale();
    }

    // Update is called once per frame
    void Update()
    {
        RotateSpikeBall();
        if (isWaiting)
        {
            HandleWaiting();
        }
        else
        {
            ScaleSpikeBall();
        }
        
    }

    private void RotateSpikeBall()
    {
        transform.Rotate(Vector3.forward, RotationAngle * Time.deltaTime);
    }

    private void ScaleSpikeBall()
    {
        currentScale += scalingFactor * scalingSpeed * Time.deltaTime;
        currentScale = Mathf.Clamp(currentScale, minScale, maxScale);
        if(currentScale == maxScale || currentScale == minScale) 
        {
            isWaiting = true;
            scalingFactor = -scalingFactor;
        }
            
        ApplyCurrentScale();
    }

    private void ApplyCurrentScale()
    {
        transform.localScale = new Vector3(currentScale, currentScale, 1);  // Update the spike's size
    }
    private void HandleWaiting()
    {
        timer += Time.deltaTime;

        if (timer >= scaleDelay) //If timer reaches the delay time
        {
            isWaiting = false;  // End the waiting period
            timer = 0f;  // Reset the timer
        }
    }
}
