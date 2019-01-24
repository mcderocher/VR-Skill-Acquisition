using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleRaycast : MonoBehaviour
{
    public GameObject whale;
    Animator whaleAnimator;

    public bool swimming;
    public bool moving;

    // Start is called before the first frame update
    void Start()
    {
        whaleAnimator = whale.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (moving = true)
        {
            whaleAnimator.SetBool("swimming", true);
        } else if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.GetComponent<isWhale>() != null)
            {
                whaleAnimator.SetBool("swimming", true);
            } else
            {
                whaleAnimator.SetBool("swimming", false);
            }
        }
        else
        {
            whaleAnimator.SetBool("swimming", false);
        }
    }
}
