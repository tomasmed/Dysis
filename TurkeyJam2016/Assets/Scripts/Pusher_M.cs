using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Pusher_M : MonoBehaviour {
    Vector3 vel = Vector3.zero;
    public bool active = false;
    public float lifetime = 5f;
    public float intensity = 3f;

    public GameObject textureHolder;

    public int bombdirection = 0;

    public Material vola;
    public Material dorm;

    private RaycastHit hitInfo;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (active)
        {
            lifetime -= Time.deltaTime;
            if (lifetime < 1)
            {
                
                //Vector3 newpos = transform.position + Vctro
                if (Physics.Raycast((transform.position + Vector3.up), Vector3.down, out hitInfo, 4, 1, QueryTriggerInteraction.Collide))
                    {
                        if (hitInfo.collider.gameObject.tag == "Ground_a")
                        {
                            Destroy(hitInfo.collider.gameObject);
                        }
                    }
                if (Physics.Raycast((transform.position + Vector3.up + Vector3.left), Vector3.down, out hitInfo, 4, 1, QueryTriggerInteraction.Collide))
                {
                    if (hitInfo.collider.gameObject.tag == "Ground_a")
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                }
                if (Physics.Raycast((transform.position + Vector3.up+ Vector3.right), Vector3.down, out hitInfo, 4, 1, QueryTriggerInteraction.Collide))
                {
                    if (hitInfo.collider.gameObject.tag == "Ground_a")
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                }
                if (Physics.Raycast((transform.position + Vector3.up + Vector3.forward), Vector3.down, out hitInfo, 4, 1, QueryTriggerInteraction.Collide))
                {
                    if (hitInfo.collider.gameObject.tag == "Ground_a")
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                }
                if (Physics.Raycast((transform.position + Vector3.up+Vector3.back), Vector3.down, out hitInfo, 4, 1, QueryTriggerInteraction.Collide))
                {
                    if (hitInfo.collider.gameObject.tag == "Ground_a")
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                }
                if (Physics.Raycast((transform.position + Vector3.up + Vector3.forward + Vector3.right), Vector3.down, out hitInfo, 2, 1, QueryTriggerInteraction.Collide))
                {
                    if (hitInfo.collider.gameObject.tag == "Ground_a")
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                }
                if (Physics.Raycast((transform.position + Vector3.up + Vector3.forward + Vector3.left), Vector3.down, out hitInfo, 2, 1, QueryTriggerInteraction.Collide))
                {
                    if (hitInfo.collider.gameObject.tag == "Ground_a")
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                }
                if (Physics.Raycast((transform.position + Vector3.up + Vector3.back + Vector3.right), Vector3.down, out hitInfo, 2, 1, QueryTriggerInteraction.Collide))
                {
                    if (hitInfo.collider.gameObject.tag == "Ground_a")
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                }
                if (Physics.Raycast((transform.position + Vector3.up+ Vector3.back + Vector3.left), Vector3.down, out hitInfo, 2, 1, QueryTriggerInteraction.Collide))
                {
                    if (hitInfo.collider.gameObject.tag == "Ground_a")
                    {
                        Destroy(hitInfo.collider.gameObject);
                    }
                }

                Destroy(gameObject);




            }
        }
    }

}
