using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public GameObject player;
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        
        offset = transform.position - player.transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.position = player.transform.position + offset;
        transform.LookAt(target);
        transform.Rotate(0.0f, moveHorizontal, 0.0f);
    }
}
