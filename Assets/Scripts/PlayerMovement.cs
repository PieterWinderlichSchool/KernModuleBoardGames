using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0, 2)] public int currentPosition = 2;
    public Coroutine currentRoutine = null;
    public List<Vector3> positionsList = new List<Vector3>();
    public float movementSpeed = 0;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && currentPosition != 0)
        {
            currentRoutine = null;
            currentPosition -= 1;
            currentRoutine = StartCoroutine(movement());
        }

        if (Input.GetKeyDown(KeyCode.D) && currentPosition != 2)
        {
            currentRoutine = null;
            currentPosition += 1;
            currentRoutine = StartCoroutine(movement());
        }
    }
    IEnumerator movement()
    {
        while (transform.position.x != positionsList[currentPosition].x)
        {
            transform.position = Vector3.MoveTowards(transform.position, positionsList[currentPosition], movementSpeed);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
