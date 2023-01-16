using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Vector3 _direction, _endPos;
    RaycastHit2D hit;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch");

            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((touch.position)), Vector2.zero);
                    if (hit.transform != null)
                    {
                        Debug.Log(hit.transform.name);
                    }
                }

                if (touch.phase == TouchPhase.Ended)
                {
                    _endPos = new Vector2(touch.position.x / (float)Screen.width, touch.position.y / (float)Screen.width);
                    GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Cube.transform.position = _endPos;
                    Debug.Log("Last Touch - " + _endPos.magnitude);
                    if (hit.transform != null)
                        hit.transform.GetComponent<ThrowBall>().StartMovement(_endPos);
                }
            }
        }
    }
}
