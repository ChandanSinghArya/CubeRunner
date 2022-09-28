using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float offset = 5;
    public Transform PlayerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CameraPos = transform.position;
        CameraPos.z = PlayerPos.position.z - offset;
        transform.position = CameraPos;
    }
}
