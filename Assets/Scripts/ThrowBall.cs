using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    [SerializeField]
    Vector3 _direction;
    [SerializeField]
    float _speed = 10f;
    [SerializeField]
    bool _Move = false;

    // Update is called once per frame
    void Update()
    {
        if (_Move)
        {
            Move();
        }
    }

    private void Move()
    {
        if (_direction != null && _Move)
        {
            transform.Translate(_direction * _speed * Time.deltaTime);
        }
    }

    public void StartMovement(Vector3 EndPos)
    {
        _direction = (EndPos - transform.position).normalized;
        _Move = true;
    }
}

