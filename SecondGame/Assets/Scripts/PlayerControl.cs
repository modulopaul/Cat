using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

    public Joystick joystick;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        if(joystick.Horizontal>= .2f)
        {
            horizontalMove = runSpeed;
        }
        else if(joystick.Horizontal<= -.2f)
        {
            horizontalMove = -runSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }

        if (joystick.Vertical >= .2f)
        {
            verticalMove = runSpeed;
        }
        else if (joystick.Vertical <= -.2f)
        {
            verticalMove = -runSpeed;
        }
        else
        {
            verticalMove = 0f;
        }
        horizontalMove = joystick.Horizontal * runSpeed;
        verticalMove = joystick.Vertical * runSpeed;
        transform.Translate(horizontalMove * Time.deltaTime, verticalMove * Time.deltaTime, 0f);
    }
}