using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    [SerializeField]
    Vector2 _direction;
    [SerializeField]
    float _speed = 10f;
    [SerializeField]
    bool _Move = false;

    // Update is called once per frame
    void Update()
    {
        if (_Move && _direction != null)
        {
            transform.Translate(_direction * _speed * Time.deltaTime);
        }
    }

    public void StartMovement(Vector3 EndPos)
    {
        _direction = (EndPos - transform.position).normalized;
        Debug.Log("Direction - " + _direction);
        _Move = true;
    }
}

