using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour
{
    //1
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;
    //from chapter 7
    private Rigidbody _rb;
    //new jump stuff
    public float JumpVelocity = 5f;
    private bool _isJumping;

    // Start is called before the first frame update
    void Start()
    {
        // from chapter 7
        _rb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {



        // Vertical input
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        // Horizontal input
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

        // Vector3 parameter to move the capsule with z axis 
        this.transform.Translate(Vector3.forward * _vInput *
            Time.deltaTime);
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);




    } 

    //More New Stuff for the Jump
    void FixedUpdate()
    {
        if(_isJumping)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }

        _isJumping = false;

        //new jumping 
        _isJumping = Input.GetKeyDown(KeyCode.Space);

    }
    
    










}

     
