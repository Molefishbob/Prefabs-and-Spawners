using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _prefab;
    public float _spawnInterval = 5f;
    private float _currentTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // Fill the current time with the time between frames
        _currentTime += Time.deltaTime;

        // Again check for timer completion
        if (_currentTime > _spawnInterval)
        {
            // Reset Timer
            _currentTime = 0f;

            // Instantiate spawns the given object. The arguments are as follows:
            // _prefab is the gameobject it has been given in the inspector
            // second one is the position you want to spawn it. I have entered the position of the spawner
            // third one is its rotation. Quaternion.identity is the "no rotation" quaternion 
            // (you don't need to completely understand quaternions yet)
            Instantiate(_prefab, transform.position, Quaternion.identity);
        }
    }
}
