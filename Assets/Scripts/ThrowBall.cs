using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    [SerializeField]
    Vector3 _direction, _endPos;
    [SerializeField]
    float _speed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    _endPos = touch.position;
                    Debug.Log("Last Touch - " + _endPos);
                    _direction = (this.transform.position - _endPos).normalized;
                }
            }
        }
        if (_endPos != null)
        {
            transform.Translate(_direction * _speed * Time.deltaTime);
        }
    }
}

