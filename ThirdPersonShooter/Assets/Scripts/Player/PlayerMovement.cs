using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float m_RunSpeed;
    [SerializeField] private float m_StrafeSpeed;
    [SerializeField] private float m_JumpForce;

    private Rigidbody m_rb;

    public bool IsGrounded { get; private set; }

    #region Player Input
    private PlayerInput m_PlayerInput;
    public Vector2 MovementInput { get; private set; }
    public bool IsFiring { get; private set; }
    public bool IsCrouching { get; private set; }
    public bool IsAiming { get; private set; }
    public bool IsInCover { get; private set; }
    public bool JumpInput { get; private set; }
    public bool Picking { get; private set; }
    #endregion

    #region Expression Body Statement Functions
    void OnEnable() => m_PlayerInput.Enable();
    void OnDisable() => m_PlayerInput.Disable();
    #endregion

    void Awake() {

        //Input
        m_PlayerInput = new PlayerInput();

        m_PlayerInput.PlayerInputMap.Move.performed += context => MovementInput = context.ReadValue<Vector2>();
        m_PlayerInput.PlayerInputMap.Move.canceled += context => MovementInput = Vector2.zero;
        
        m_PlayerInput.PlayerInputMap.Aim.performed += context => IsAiming = true;
        m_PlayerInput.PlayerInputMap.Aim.canceled += context => IsAiming = false;
        
        m_PlayerInput.PlayerInputMap.Jump.performed += context => JumpInput = true;
        m_PlayerInput.PlayerInputMap.Jump.canceled += context => JumpInput = false;

        m_PlayerInput.PlayerInputMap.Shoot.performed += context => IsFiring = true;
        m_PlayerInput.PlayerInputMap.Shoot.canceled += context => IsFiring = false;

        m_PlayerInput.PlayerInputMap.Pickup.performed += context => Picking = true;
        m_PlayerInput.PlayerInputMap.Pickup.canceled += context => Picking = false;

        m_PlayerInput.PlayerInputMap.Crouch.performed += context => IsCrouching = !IsCrouching;

        //Rigidbody
        m_rb = GetComponent<Rigidbody>();

        //grounded (hack for now)
        IsGrounded = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move() {

        if (IsGrounded) {
            m_rb.position += this.gameObject.transform.forward * MovementInput.y * m_RunSpeed * Time.deltaTime;
            m_rb.position += this.gameObject.transform.right * MovementInput.x * m_StrafeSpeed * Time.deltaTime;

            if (JumpInput) this.gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.cyan;
            else if (IsFiring) this.gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
            else if (IsCrouching) this.gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.green;
            else if (IsAiming) this.gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.yellow;
            else if (Picking) this.gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.gray;
            else this.gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.white;
        }
    }

    void Jump() { }
}
