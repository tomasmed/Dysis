using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReloadGame1 : MonoBehaviour {

    public KeyCode restart;
    public string scene = "Scene0";

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("A") || Input.GetButtonDown("A2"))
        {
            SceneManager.LoadScene("Scene0", LoadSceneMode.Single);
        }
	}
}
