using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private CharacterController cc;
    private Vector2 moveVector;
    private Vector2 cameraDir;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        cameraDir = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        cc.Move(new Vector3(moveVector.x, -10f, moveVector.y) * Time.deltaTime * 5f);
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
        
    }
}
