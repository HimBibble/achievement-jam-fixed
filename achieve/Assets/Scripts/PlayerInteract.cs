using UnityEngine;
using System.Collections;

public class PlayerInteract : MonoBehaviour
{
    private float interactionRadius = 1;
    public void SquawkInteract()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, interactionRadius);
        foreach (Collider2D hitCollider in hitColliders)
        {
            GameObject hitGameObject = hitCollider.gameObject;
            Debug.Log(hitGameObject.name);
            if(hitGameObject.tag=="Squawk"){hitGameObject.GetComponent<TreeTile>().Interact();}
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject otherGameObject=collider.gameObject;
        if(otherGameObject.gameObject.tag=="Collision")
        {
            if(otherGameObject.GetComponent<FlowerTile>()!=null){otherGameObject.GetComponent<FlowerTile>().Interact();}
            else if(otherGameObject.GetComponent<Flytrap>()!=null){otherGameObject.GetComponent<Flytrap>().Interact();}
        }
    }
}
