using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    // 1 
    public Vector3 CamOffset = new Vector3(0f, 3f, -5f);

    // 2 
    public Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        // 3
        _target = GameObject.Find("Player").transform;
    }


    // Update is called once per frame
    void Update()
    {
        // 5
        this.transform.position = _target.TransformPoint(CamOffset);

        // 6
        this.transform.LookAt(_target);
    }
}
