using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] private Transform m_LeftHandPoint;
    [SerializeField] private Transform m_RightHandPoint;

    void Awake() {
        //transform.Translate(m_RightHandPoint.position - transform.position);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
