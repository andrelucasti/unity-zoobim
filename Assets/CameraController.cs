using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 compensation = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        compensation = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + compensation;
    }
}
