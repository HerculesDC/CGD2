using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private PlayerMovement m_Player; //have states go through the player instead of having them organized through inputs
    [SerializeField] private RawImage m_Crosshairs;
    [SerializeField] private Image m_Pickup; //refine
    void Awake() {
        //Investigate setup for the image
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Player.IsAiming) { m_Crosshairs.material.color = Color.green; }
        else { m_Crosshairs.material.color = new Color(0, 0, 0, 0); }
    }
}
