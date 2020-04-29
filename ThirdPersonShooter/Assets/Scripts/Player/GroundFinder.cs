using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFinder : MonoBehaviour
{
    [SerializeField] private float m_DistToGround;
    //may require refining
    public bool Grounded => Physics.Raycast(this.gameObject.transform.position, Vector3.down, m_DistToGround);

    // Update is called once per frame //Will have to be cleaned up
    void Update() {
        Debug.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.down * m_DistToGround, Color.red);
    }
}
