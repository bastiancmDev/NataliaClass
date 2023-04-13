using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemento : MonoBehaviour
{
    public float horizontalMove;
    public GameObject ModelObject;
    public float verticalMove;
    public CharacterController player;
    public float playerSpeed = 4.0F;
    private Vector3 movePlayer;
    private Vector3 camRight;
    private Vector3 camForward;
    private Vector3 playerInput;
    public Camera mainCam;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        

        playerInput = new Vector3(horizontalMove, 0, verticalMove);
       
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;
        

        player.Move(playerInput * playerSpeed * Time.deltaTime);

        ModelObject.transform.forward = player.velocity ;


    }

    

    void camDirection()
    {
        camForward = mainCam.transform.forward;
        camRight = mainCam.transform.right;

        camForward.y = 0;
        camRight.z = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }
}
