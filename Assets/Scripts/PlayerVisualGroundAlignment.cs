using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisualGroundAlignment : MonoBehaviour
{
    [SerializeField] private Transform visualModel;
    [SerializeField] private float raycastDistance;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Ray ray = new Ray(transform.position + Vector3.up * 0.1f, Vector3.down);

        if (Physics.Raycast(ray, out RaycastHit hit, raycastDistance, groundLayer))
        {
            float distanceToGround = hit.distance;

            // Offset the visual so it touches the ground
            visualModel.localPosition = new Vector3(0, -distanceToGround + 0.1f, 0);
        }
    }
}
