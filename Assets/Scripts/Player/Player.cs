using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayer;
    [SerializeField] private float rayDistance;
    [SerializeField] private GameObject interactPopUpContainer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position + Vector3.up * 1f, transform.forward);

        if(Physics.Raycast(ray, out RaycastHit hit, rayDistance, interactableLayer))
        {
            // Tells which collider is hit by the ray
            //Debug.Log("Hit object: " + hit.collider.gameObject.name);

            
            interactPopUpContainer.gameObject.SetActive(true); // "Press 'E' to interact" message pop up

            if (Input.GetKeyDown(KeyCode.E))
            {
                hit.collider.GetComponent<Interactable>()?.Interact();
            }
        }
        else
        {
            interactPopUpContainer.gameObject.SetActive(false);
        }
    }
}
