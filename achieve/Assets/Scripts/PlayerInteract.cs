using UnityEngine;
using System.Collections;

public class PlayerInteract : MonoBehaviour
{
    private float interactionRadius = 2;
    private bool InLevel = true;
    public bool inLevel {get{return InLevel;} set{InLevel=value;}}
    public void SquawkInteract()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, interactionRadius);
        foreach (Collider2D hitCollider in hitColliders)
        {
            GameObject otherGameObject = hitCollider.gameObject;
            //Debug.Log(otherGameObject.name);
            if(otherGameObject.tag=="Squawk")
            {
                if(otherGameObject.GetComponent<TreeTile>()!=null){otherGameObject.GetComponent<TreeTile>().Interact();}
                else if(otherGameObject.GetComponent<Beehive>()!=null){otherGameObject.GetComponent<Beehive>().Interact();}
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject otherGameObject=collider.gameObject;
        if(otherGameObject.gameObject.tag=="Collision")
        {
            if(otherGameObject.GetComponent<FlowerTile>()!=null){otherGameObject.GetComponent<FlowerTile>().Interact();}
            else if(otherGameObject.GetComponent<Flytrap>()!=null){otherGameObject.GetComponent<Flytrap>().Interact();}
            else if(otherGameObject.GetComponent<ZoneTile>()!=null){otherGameObject.GetComponent<ZoneTile>().Interact();}
            else if(otherGameObject.GetComponent<ExitDoor>()!=null){otherGameObject.GetComponent<ExitDoor>().Interact();}
            else if(otherGameObject.GetComponent<BeeSwarm>()!=null){otherGameObject.GetComponent<BeeSwarm>().Interact();}
        }
        if(otherGameObject.name=="Main Level"){inLevel=true;}
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        GameObject otherGameObject=collider.gameObject;
        if(otherGameObject.name=="Main Level"){inLevel=false;}
    }
}
