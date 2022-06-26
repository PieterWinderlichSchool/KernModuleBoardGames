using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        movement();
    }

    public void movement()
    {

        transform.position += new Vector3(0, 0, -movementSpeed * Time.deltaTime);
        
    }
}
