using UnityEngine;

public class Timer : MonoBehaviour
{
    public float _duration = 5f;
    private float _currentTime = 0f;

    private void Start()
    {
        // Changing this value can slow down or quicken the flow of time (in game)
        // >1 = faster than normal 🤠
        //  1 = normal
        //  0 = stop
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        // Add the time between the previous and current frame to the current time
        _currentTime += Time.deltaTime;

        // This will send a message to the Console tab in Unity and tell the value of this parameter
        // This will also spam the console so turn it off if you want to actually check something
        Debug.Log(_currentTime);

        // Check if current time is past the duration
        if (_currentTime > _duration)
        {
            // Do the desired action when the timer is done

            // This message should show up in the console when the timer is done
            Debug.Log("Timer is done");

            // You can also reset the timer here if you want it to run constantly
            _currentTime = 0;
        }
    }
}
