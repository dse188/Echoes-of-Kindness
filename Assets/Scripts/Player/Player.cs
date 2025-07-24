using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayer;
    [SerializeField] private float rayDistance;
    [SerializeField] private GameObject interactPopUpContainer;

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position + Vector3.up * 1f, transform.forward);

        if(Physics.Raycast(ray, out RaycastHit hit, rayDistance, interactableLayer))
        {
            interactPopUpContainer.gameObject.SetActive(true); // "Press 'E' to interact" message pop up
            if (Input.GetKeyDown(KeyCode.E))
            {
                var interactable = hit.collider.GetComponent<Interactable>();
                interactable?.Interact();
            }
        }
        else
        {
            interactPopUpContainer.gameObject.SetActive(false);
        }
    }
}
