using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;

public class MovementController : MonoBehaviour {
    public Rigidbody rb;
    public Transform trans;
    public float speed;
    Vector3 vel;

    private RaycastHit hitInfo;
    public bool horiz_axis_in_use = false;
    private bool vert_axis_in_use = false;

    public List<GameObject> BombBelt;

    public static MovementController S;

    void Awake() { S = this; }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        vel = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetAxis("Trigger1") == 1)
        {
            for (int i = 0; i < BombBelt.Count; i++)
            {
                BombBelt[i].GetComponent<Pusher>().active = true;
                BombBelt[i].GetComponent<Pusher>().textureHolder.GetComponent<Renderer>().material = BombBelt[i].GetComponent<Pusher>().vola;
            }
            BombBelt = new List<GameObject>();
        }

        if (Input.GetKeyDown(KeyCode.W)){
            if (!Physics.Raycast(trans.position, Vector3.right, out hitInfo, 1,1,QueryTriggerInteraction.Ignore))
            {
                    transform.DOMove(new Vector3(trans.position.x + 1, trans.position.y, trans.position.z), 0.01f);
            }
            else if (hitInfo.collider.gameObject.tag != "Wall")
            {
                transform.DOMove(new Vector3(trans.position.x + 1, trans.position.y, trans.position.z), 0.01f);
            }
        }
        if (Input.GetKeyDown(KeyCode.S)){
            if (!Physics.Raycast(trans.position, Vector3.left, out hitInfo, 1,1, QueryTriggerInteraction.Ignore))
            {
                vel = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
                transform.DOMove(vel, 0.01f);
            }
            else if (hitInfo.collider.gameObject.tag != "Wall")
            {
                vel = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
                transform.DOMove(vel, 0.01f);
            }
        }



        if (Input.GetAxis("Horizontal") < -0.8)
        {
            if (horiz_axis_in_use == false)
            {
                if (!Physics.Raycast(trans.position, Vector3.forward, out hitInfo, 1, 1, QueryTriggerInteraction.Ignore))
                {
                    vel = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
                    transform.DOMove(vel, 0.01f);
                }
                else if (hitInfo.collider.gameObject.tag != "Wall")
                {
                    vel = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
                    transform.DOMove(vel, 0.01f);
                }
                horiz_axis_in_use = true;
            }
        }
        if (Input.GetAxis("Horizontal") > 0.8)
        {
            if (horiz_axis_in_use == false)
            {
                if (!Physics.Raycast(trans.position, Vector3.back, out hitInfo, 1, 1, QueryTriggerInteraction.Ignore))
                {
                    vel = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
                    transform.DOMove(vel, 0.01f);
                }
                else if (hitInfo.collider.gameObject.tag != "Wall")
                {
                    vel = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
                    transform.DOMove(vel, 0.01f);
                }
                horiz_axis_in_use = true;
            }
        }
        if (Input.GetAxis("Horizontal") > -0.8 && Input.GetAxis("Horizontal") < 0.8) 
        {
            horiz_axis_in_use = false;
        }


        if (Input.GetAxis("Vertical") < -0.8)
        {
            if (vert_axis_in_use == false)
            {
                if (!Physics.Raycast(trans.position, Vector3.right, out hitInfo, 1, 1, QueryTriggerInteraction.Ignore))
                {
                    vel = new Vector3(trans.position.x + 1, trans.position.y, trans.position.z);
                    transform.DOMove(vel, 0.01f);
                }
                else if (hitInfo.collider.gameObject.tag != "Wall")
                {
                    vel = new Vector3(trans.position.x + 1, trans.position.y, trans.position.z);
                    transform.DOMove(vel, 0.01f);
                }
                vert_axis_in_use = true;
            }
        }
        if (Input.GetAxis("Vertical") > 0.8)
        {
            if (vert_axis_in_use == false)
            {
                if (!Physics.Raycast(trans.position, Vector3.left, out hitInfo, 1, 1, QueryTriggerInteraction.Ignore))
                {
                    vel = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
                    transform.DOMove(vel, 0.01f);
                }
                else if (hitInfo.collider.gameObject.tag != "Wall")
                {
                    vel = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
                    transform.DOMove(vel, 0.01f);
                }
                vert_axis_in_use = true;
            }
        }
        if (Input.GetAxis("Vertical") > -0.8 && Input.GetAxisRaw("Vertical") < 0.8)
        {
            vert_axis_in_use = false;
        }













        
        if (Input.GetKeyDown(KeyCode.A)){
            if (!Physics.Raycast(trans.position, Vector3.forward, out hitInfo, 1,1, QueryTriggerInteraction.Ignore))
            {
                    vel = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
                    transform.DOMove(vel, 0.01f);
            }
            else if (hitInfo.collider.gameObject.tag != "Wall")
            {
                vel = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
                transform.DOMove(vel, 0.01f);
            }
        }
        if (Input.GetKeyDown(KeyCode.D)){
            if (!Physics.Raycast(trans.position, Vector3.back, out hitInfo, 1,1, QueryTriggerInteraction.Ignore))
            {
                vel = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
                transform.DOMove(vel, 0.01f);
            }
            else if (hitInfo.collider.gameObject.tag != "Wall")
            {
                vel = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
                transform.DOMove(vel, 0.01f);
            }
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Void")
        {
            //Load Scene PLayer 1 Won
            SceneManager.LoadScene("VictoryP2", LoadSceneMode.Single);
            Debug.Log("Player 2 Wins!");
        }
    }
}
