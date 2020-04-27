using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    #region Positioning Variables
    [SerializeField] private Transform m_Player;
    [SerializeField] private Transform m_Normal;
    [SerializeField] private Transform m_Zoom;
    [SerializeField] private Transform m_PivotPoint;
    [SerializeField] private PlayerMovement m_playerMov;
    [SerializeField] private float m_MovementStep;
    #endregion
    #region FoV Controls
    [SerializeField] private float m_NormalFoVAngle;
    [SerializeField] private float m_ZoomFoVAngle;
    [SerializeField] private float m_ZoomStep;
    #endregion
    private Camera m_cam;
    private Rigidbody m_rb;
    private SphereCollider m_collider;
    private bool m_isCollidingWithPlayer;
    
    void Awake() {
        m_cam = this.gameObject.GetComponent<Camera>();
        m_rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float fovTarget = 0.0f;
        if (m_playerMov.IsAiming) {
            if (!m_isCollidingWithPlayer) {  m_rb.position = Vector3.MoveTowards(m_rb.position, m_Zoom.position, m_MovementStep); }
            fovTarget = Mathf.Lerp(m_NormalFoVAngle, m_ZoomFoVAngle, m_ZoomStep);
        }
        else {
            m_rb.position = Vector3.MoveTowards(m_rb.position, m_Normal.position, m_MovementStep);
            fovTarget = Mathf.Lerp(m_ZoomFoVAngle, m_NormalFoVAngle, m_ZoomStep);
        }
        m_cam.fieldOfView = fovTarget;
        this.gameObject.transform.LookAt(m_PivotPoint);
    }
    void Zoom() {

    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") { m_isCollidingWithPlayer = true; }
    }
    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.tag == "Player") { m_isCollidingWithPlayer = false; }
    }

}
