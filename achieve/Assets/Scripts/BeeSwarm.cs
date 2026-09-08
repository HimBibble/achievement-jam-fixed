using UnityEngine;

public class BeeSwarm : Interactable
{
    [SerializeField] private float speed=1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        this.gameObject.tag="Collision";
    }

    // Update is called once per frame
    void Update()
    {
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
    }
    public override void Interact()
    {
        player.GetComponent<PlayerDeath>().Kill();
        TriggerData.SetTrigger("DieBees",true);
        GameObject.Destroy(this.gameObject);
    }
}
