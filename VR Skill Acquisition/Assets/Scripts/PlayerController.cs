using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;

public class PlayerController : MonoBehaviour
{
    public int speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.z += moveVertical * speed * Time.deltaTime;
        transform.position = position;*/

        //reading the input:
        float horizontalAxis = CrossPlatformInputManager.GetAxis("Horizontal");
        float verticalAxis = CrossPlatformInputManager.GetAxis("Vertical");

        //assuming we only using the single camera:

        //camera forward and right vectors:
        var forward = transform.forward;
        var right = transform.right;

        //project forward and right vectors on the horizontal plane (y = 0)
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        //this is the direction in the world space we want to move:
        var desiredMoveDirection = forward * verticalAxis + right * horizontalAxis;

        //now we can apply the movement:
        transform.Translate(desiredMoveDirection * speedMeUp * Time.deltaTime);
    }
}
