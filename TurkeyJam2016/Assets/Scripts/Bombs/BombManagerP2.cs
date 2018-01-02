using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BombManagerP2 : MonoBehaviour
{

    public GameObject pusherN;
    public GameObject pusherS;
    public GameObject pusherW;
    public GameObject pusherE;

    public int maxbombs;
    public Text uibombs;


    private GameObject temp;
    Vector3 objectivepos = Vector3.zero;
    // Use this for initialization
    void Start()
    {
        maxbombs = Controller.S.bombsthisround;
        uibombs.text = "Bombs Left: " + maxbombs;

    }



    // Update is called once per frame
    void Update()
    {
        if (Mathf.Floor(Controller.S.timesofar) % Controller.S.bombrefreshtime == 0)
        {
            maxbombs = Controller.S.bombsthisround;
            uibombs.text = "Bombs Left: " + maxbombs;

        }
        if (Input.GetButtonDown("Y2") && (maxbombs > 0))
        {
            objectivepos = this.gameObject.transform.position;// + Vector3.forward * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherN, objectivepos, transform.rotation);
            MovementPlayer2.S.BombBelt.Add(temp);
            maxbombs--;
            uibombs.text = "Bombs Left: " + maxbombs;

        }
        if (Input.GetButtonDown("A2") && (maxbombs > 0))
        {
            objectivepos = this.gameObject.transform.position;// + Vector3.forward * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherS, objectivepos, transform.rotation);
            MovementPlayer2.S.BombBelt.Add(temp);
            maxbombs--;
            uibombs.text = "Bombs Left: " + maxbombs;

        }
        if (Input.GetButtonDown("X2") && (maxbombs > 0))
        {
            objectivepos = this.gameObject.transform.position;// + Vector3.forward * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherW, objectivepos, transform.rotation);
            MovementPlayer2.S.BombBelt.Add(temp);
            maxbombs--;
            uibombs.text = "Bombs Left: " + maxbombs;

        }
        if (Input.GetButtonDown("B2") && (maxbombs > 0))
        {
            objectivepos = this.gameObject.transform.position;// + Vector3.forward * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherE, objectivepos, transform.rotation);
            MovementPlayer2.S.BombBelt.Add(temp);
            maxbombs--;
            uibombs.text = "Bombs Left: " + maxbombs;

        }
    }
}