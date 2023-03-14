using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] CharacterController characterController;
    [SerializeField] float _horizontalMovement;
    [SerializeField] float _verticalMovement;
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = Input.GetAxis("Horizontal");
        _verticalMovement = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        characterController.Move(new Vector3(_horizontalMovement, 0, _verticalMovement));
    }
}
