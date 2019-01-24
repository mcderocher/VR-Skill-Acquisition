using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whaleTouch : MonoBehaviour
{
    public GameObject whale;
    Animator whaleAnimator;

    // Start is called before the first frame update
    void Start()
    {
        whaleAnimator = whale.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        whaleAnimator.SetBool("moving", true);
        //yield return new WaitForSeconds(10);
        whaleAnimator.SetBool("moving", false);
    }
}
