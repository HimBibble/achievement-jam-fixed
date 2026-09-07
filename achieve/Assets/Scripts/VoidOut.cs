using UnityEngine;
using UnityEngine.Tilemaps;

public class VoidOut : MonoBehaviour
{
    GameObject player;
    Tilemap tilemap;
    Vector2 playerPos;
    Vector2 tilePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        tilemap=GameObject.Find("Grid").transform.GetChild(0).GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        /*playerPos = player.transform.position;
        tilePos.x = Mathf.Floor( (playerPos.x*2) /2f);
        tilePos.y = Mathf.Floor( (playerPos.y*2) /2f);
        Debug.Log(tilePos.x);
        Debug.Log(tilePos.y);
        Debug.Log(tilemap.GetTile(new Vector3Int((int)tilePos.x,(int)tilePos.y,0)));*/
    }
}
