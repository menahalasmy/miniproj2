using UnityEngine;
using System.Collections;

public class claire : MonoBehaviour
{
    private Animator anim;
    private bool w,r,l;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            l = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            l = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            r = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            r = false;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            w = true;
        }
            else
            {
                w = false;
            }

        anim.SetBool("walk", w);
        anim.SetBool("right", r);
        anim.SetBool("left", l);


    }
}