using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Controller : MonoBehaviour {



    public float timesofar = 0f;
    public int bombsthisround = 10;
    public Text bombtimer;
    public float bombrefreshtime = 19;
    public int suddendeath = 0;
    public static Controller S;

    public GameObject masterB;
    Vector3 objectivepos;
    Vector3 objectivepos2;


    void Awake()
    {
        S = this;
    }


	// Use this for initialization
	void Start () {
        bombtimer.text = "Time Until Bombs: " + (bombrefreshtime-timesofar);
	
	}
	
	// Update is called once per frame
	void Update () {
        if ((bombrefreshtime - timesofar < 0))
        {
            timesofar = 0f;
            suddendeath++;
            if (suddendeath > 1)
            {
                // Spawn bombs for player 1

                objectivepos = new Vector3((-7 - (Mathf.Floor(Random.Range(0, 8)))), (1), (18 - (Mathf.Floor(Random.Range(0, 8)))));
                GameObject.Instantiate(masterB, objectivepos, transform.rotation);


                //Spawn bombs for player 2
                objectivepos2 = new Vector3((-7 - (Mathf.Floor(Random.Range(0, 8)))), (1), (6 - (Mathf.Floor(Random.Range(0, 8)))));
                GameObject.Instantiate(masterB, objectivepos2, transform.rotation);
            }
        }
        timesofar += Time.deltaTime;
        bombtimer.text = "Time Until Bombs: " + (bombrefreshtime - timesofar);


        
    }
}
