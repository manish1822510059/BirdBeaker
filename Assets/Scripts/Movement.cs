using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;   

public class Movement : MonoBehaviourPunCallbacks
{
    public static bool PlayerMoving = true;
    public float walkSpeed = 10f;
    public float rotationSpeed = 300f;
    public PhotonView view;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting");
        // view = GetComponent<PhotonView>();

    }

    // Update is called once per frame
    void Update()
    {
    if(view.IsMine){
      if(PlayerMoving){
        CalculateRotation();
        CalculatePositon();
       }
      } 
    }

    private void CalculateRotation()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float rotationValue = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationValue, 0);
    }

    private void CalculatePositon()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 movementDirection = transform.forward * verticalInput;
        Vector3 positionChange = movementDirection * walkSpeed * Time.deltaTime;
        this.transform.position += positionChange;
    }
}
