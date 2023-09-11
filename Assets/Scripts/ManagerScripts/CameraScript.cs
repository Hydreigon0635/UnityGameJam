using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public GameObject gameObject;
    public Vector3 offset = new Vector3(0, 0, 0);
    private BallScript ballscript;
    // Start is called before the first frame update
    void Start()
    {
        ballscript = gameObject.GetComponent<BallScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null && ballscript.CheckFlag()){
            transform.position = target.position + offset;
        }

    }
}
