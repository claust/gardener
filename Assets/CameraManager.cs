using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    float Speed = 0.5f;
    [SerializeField]
    float MaxSpeed = 0.02f;
    [SerializeField]
    Vector2 XRange = new Vector2(-10, 15);
    [SerializeField]
    Vector2 ZRange = new Vector2(-10, 8);


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal") * Speed;
        float zAxisValue = Input.GetAxis("Vertical") * Speed;

        xAxisValue = Mathf.Clamp(xAxisValue, -MaxSpeed, MaxSpeed);
        zAxisValue = Mathf.Clamp(zAxisValue, -MaxSpeed, MaxSpeed);
        var x = Mathf.Clamp(transform.position.x + xAxisValue, XRange.x, XRange.y);
        var z = Mathf.Clamp(transform.position.z + zAxisValue, ZRange.x, ZRange.y);
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
