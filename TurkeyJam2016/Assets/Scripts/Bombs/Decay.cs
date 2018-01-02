using UnityEngine;
using System.Collections;

public class Decay : MonoBehaviour {
    public bool active = false;
    public  float lifetime = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (active)
        {
            lifetime -= Time.deltaTime;
            if (lifetime < 1) Destroy(gameObject);
        }
	}
}
