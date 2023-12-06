using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    float speed = 5f;
    Vector3 Vector;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector = new Vector3(Horizontal, 0f, Vertical) * speed * Time.deltaTime;
        transform.position += Vector;
    }

}
