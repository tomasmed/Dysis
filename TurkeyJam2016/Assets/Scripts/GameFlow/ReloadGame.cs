using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReloadGame : MonoBehaviour {

    public KeyCode restart;
    public string scene = "Scene0";

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(restart))
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
	}
}
