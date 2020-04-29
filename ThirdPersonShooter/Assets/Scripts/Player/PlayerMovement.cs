using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    #region Movement Specs
    [SerializeField] private float m_RunSpeed;
    [SerializeField] private float m_StrafeSpeed;
    [SerializeField] private float m_AirborneFactor;
    [SerializeField] private float m_JumpForce;
    #endregion

    #region Camera Points
    [SerializeField] private Transform m_PivotPoint;
    [SerializeField] private Vector3 m_NormalPivotPoint;
    [SerializeField] private Vector3 m_CrouchPivotPoint;
    [SerializeField, Tooltip("X for horizontal speed, Y for vertical speed")] 
    private Vector2 m_PivotSpeed;
    #endregion

    #region Model Properties
    [SerializeField] private GroundFinder m_LeftFooting;
    [SerializeField] private GroundFinder m_RightFooting;
    #endregion

    #region Animator Controls
    private Animator m_anim;
    #endregion

    //this will probably go later
    [SerializeField] private Transform m_Arm;

    private Rigidbody m_rb;

    public bool IsGrounded => m_LeftFooting.Grounded || m_RightFooting.Grounded;

    #region Player Input
    private PlayerInput m_PlayerInput;
    public Vector2 MovementInput { get; private set; }
    public Vector2 LookInput { get; private set; }
    public bool CameraReset { get; private set; }
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

        m_PlayerInput.PlayerInputMap.Look.performed += context => LookInput = context.ReadValue<Vector2>();
        m_PlayerInput.PlayerInputMap.Look.canceled += context => LookInput = Vector2.zero;

        m_PlayerInput.PlayerInputMap.ResetCamera.performed += context => CameraReset = true;
        m_PlayerInput.PlayerInputMap.ResetCamera.canceled += context => CameraReset = false;

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

            if (JumpInput) {
                Jump();
            }
            else if (IsFiring) { }
            else if (IsCrouching) {
                Crouch();
            }
            else if (IsAiming) { }
            else if (Picking) { }
            else {
                UnCrouch();
            }
        }
        else {
            m_rb.position += this.gameObject.transform.forward * MovementInput.y * m_RunSpeed * m_AirborneFactor * Time.deltaTime;
            m_rb.position += this.gameObject.transform.right * MovementInput.x * m_StrafeSpeed * m_AirborneFactor * Time.deltaTime;
        }
    }
    void Crouch() {
        m_PivotPoint.localPosition = m_CrouchPivotPoint;
    }
    void UnCrouch() {
        m_PivotPoint.localPosition = m_NormalPivotPoint;
    }
    void FixedUpdate() {
        UpdateCameraPoints();
        m_Arm.up = m_PivotPoint.forward;
    }
    void Jump() {
        m_rb.AddForce(Vector3.up * m_JumpForce);
    }

    void UpdateCameraPoints() {
        //Requires refinement
        m_PivotPoint.Rotate(new Vector3(LookInput.y*m_PivotSpeed.x, LookInput.x * m_PivotSpeed.y, 0)*Time.fixedDeltaTime);
        
        if (CameraReset) {
            CameraReset = false;
            m_PivotPoint.localRotation = Quaternion.identity;
        }
        this.gameObject.transform.forward = new Vector3(m_PivotPoint.forward.x, transform.forward.y, m_PivotPoint.forward.z);
    }

    void Fire() {

    }
}