using UnityEngine;
using System.Collections;

public class PlayerInteract : MonoBehaviour
{
    private float interactionRadius = 10;
    public void SquawkInteract()
    {
        Collider[] hitColliders = Physics.OverlapSphere(this.gameObject.transform.position, interactionRadius);
        foreach (Collider hitCollider in hitColliders)
        {
            GameObject hitGameObject = hitCollider.gameObject;
            if(hitGameObject.tag=="Squawk"){hitGameObject.GetComponent<Interactable>().Interact();}
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGameObject=collision.gameObject;
        if(otherGameObject.gameObject.tag=="Collision")
        {
            otherGameObject.GetComponent<Flytrap>().Interact();
        }
    }
}
