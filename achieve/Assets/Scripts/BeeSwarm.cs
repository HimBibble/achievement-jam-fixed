using UnityEngine;

public class BeeSwarm : Interactable
{
    private GameObject player;
    [SerializeField] private float speed=1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.tag="Collision";
        player=GameObject.Find("Player");
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
        GameObject.Destroy(this.gameObject);
    }
}
