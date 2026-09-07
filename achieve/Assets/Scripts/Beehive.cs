using UnityEngine;

public class Beehive : Interactable
{
    private Animator anim;
    private bool isInteracted=false;
    [SerializeField] private GameObject beeSwarm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim=GetComponent<Animator>();
        this.gameObject.tag="Squawk";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Interact()
    {
        if(!isInteracted)
        {
            anim.SetBool("isInteracted",true);
            isInteracted=true;
            SpawnBeeSwarm();
        }
    }
    private void SpawnBeeSwarm()
    {
        Instantiate(beeSwarm, new Vector2(transform.position.x,transform.position.y), Quaternion.identity);
    }
}
