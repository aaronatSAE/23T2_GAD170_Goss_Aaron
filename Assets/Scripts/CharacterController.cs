using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private void Update()
    {
        // Move our object based on input from the player
        // We'll need an IF STATEMENT when we want to get the player input
        //
        // EXAMPLE...
        //int playerScore = 1;
        //playerScore++;
        ////playerScore = playerScore + 1;
        //playerScore += 1;
        // END EXAMPLE
        //
        // transform.position++; DOESN"T WORK
        //Vector3 moveDirection = Vector3.forward;
        ////transform.position = transform.position + moveDirection;
        //transform.position += moveDirection;
        //
        // When player presses arrow keys (or WASD)...
        // ...the gameobject moves in the respective direction
        //
        // we need to CREATE A VECTOR
        // X, Y, Z
        // 0
        //
        // if "pressing D", then move +X
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right;
        //}
        //// if "pressing A", then move -X
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left;
        //}
        // no jump...     so no +Y or -Y
        // if "pressing W", then move +Z
        // if "pressing S", then move -Z

        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * 5, 0, Input.GetAxis("Vertical") * Time.deltaTime * 5);
    }
}
