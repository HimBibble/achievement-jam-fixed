using UnityEngine;

public class Beehive : Interactable
{
    private Animator anim;
    private bool isInteracted=false;
    [SerializeField] private GameObject beeSwarm;
    private float endPos;
    [SerializeField] private AnimationClip animation;
    //[SerializeField] private Sprite fallenSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        endPos=transform.position.y-1f;
        anim=GetComponent<Animator>();
        this.gameObject.tag="Squawk";
    }

    // Update is called once per frame
    void Update()
    {
        if(isInteracted){
            transform.position = Vector3.MoveTowards(transform.position, new Vector2(transform.position.x,endPos), Time.deltaTime*2);
        }
    }
    public override void Interact()
    {
        if(!isInteracted)
        {
            //anim.SetBool("isInteracted",true);
            anim.Play("Fall");
            isInteracted=true;
            SpawnBeeSwarm();
            TriggerData.SetTrigger("SpawnBees",true);
        }
    }
    private void SpawnBeeSwarm()
    {
        Instantiate(beeSwarm, new Vector2(transform.position.x,transform.position.y), Quaternion.identity);
    }
}
