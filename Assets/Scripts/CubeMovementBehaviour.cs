using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * 5 * Time.deltaTime;
    }
}
