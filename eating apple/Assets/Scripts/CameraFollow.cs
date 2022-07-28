using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
        offSet =transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = player.position + offSet;
        newPos.y = transform.position.y;
        transform.position = Vector3.Slerp(transform.position, newPos, 0.5f);
    }
}
