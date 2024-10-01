using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("Physic Settings")]
    [SerializeField] public float forceMult = 10f;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(h, 0.0f, v) * forceMult;
        GetComponent<Rigidbody>().AddForce(force);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
