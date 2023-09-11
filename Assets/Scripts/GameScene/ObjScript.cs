using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjScript : MonoBehaviour
{
    public float collect_angle;
    public float angle;
    public bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0f, 0f, 15f));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0f, 0f, -15f));
        }

        angle = Mathf.Round(transform.eulerAngles.z);

        Debug.Log("正解" + collect_angle);
        Debug.Log("角度" + angle);
    }

    public bool CheckAngle()
    {

        if(collect_angle == angle){
            return true;
        }
        else{
            return false;
        }
    }
}
