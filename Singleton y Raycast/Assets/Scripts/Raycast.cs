using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private Transform rayPoint;
    [SerializeField] private Transform endPoint;

    [SerializeField]
    [Range(1f, 10f)]
    private float rayDistance = 10;

    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        CannonRaycast();
    }
    private void CannonRaycast()
    {
        RaycastHit hit;


            if (Physics.Raycast(rayPoint.position, endPoint.position, out hit, rayDistance))
            {
                if (hit.transform.CompareTag("Player"))
                {
                Debug.Log("El Raycast colisiona con el player");
                }
            }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(rayPoint.position, endPoint.position);
    }
}
