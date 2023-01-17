using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Vector2 _direction, _endPos;
    RaycastHit2D hit;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
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
                    _endPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y));
                    //GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    //Cube.transform.position = EndPos;
                    //Debug.Log("Last Touch - " + _endPos);
                    if (hit.transform != null)
                        hit.transform.GetComponent<ThrowBall>().StartMovement(_endPos);
                }
            }
        }
    }
}
