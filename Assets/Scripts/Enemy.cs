using UnityEngine;
using UnityEngine.PlayerLoop;

public class Enemy : MonoBehaviour
{
    // The maximum X-axis value of the enemy's position
    public float _maxX;
    // The minimum X-axis value of the enemy's position
    public float _minX;
    // The enemy's speed
    public float _speed;
    // Is the enemy moving left? (if false it is moving right)
    public bool _isMovingLeft;

    // Update is called once per frame
    void Update()
    {
        // Check if the enemy is moving left
        if (_isMovingLeft)
        {
            // Move the enemy to the left according to his speed. Remember to always use Time.DeltaTime!
            transform.position -= new Vector3(_speed, 0) * Time.deltaTime;

            // Check if the enemy is beyond its minimum X-axis value.
            if (_minX > transform.position.x)
            {
                // If it is, make the moving left boolean false and move the player to its minimum X-axis value.
                _isMovingLeft = false;
                transform.position = new Vector3(_minX, transform.position.y);
            }
        }
        else
        {
            // Move the enemy to the right according to his speed. Remember to always use Time.DeltaTime!
            transform.position += new Vector3(_speed, 0) * Time.deltaTime; 
            
            if (_maxX < transform.position.x)
            {
                // If it is, make the moving left boolean true and move the player to its maximum X-axis value.
                _isMovingLeft = true;
                transform.position = new Vector3(_maxX, transform.position.y);
            }
        }
    }
}
