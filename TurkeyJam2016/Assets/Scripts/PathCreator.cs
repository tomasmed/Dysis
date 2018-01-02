using UnityEngine;
using System.Collections;

public class PathCreator : MonoBehaviour {

    public bool isinhabited = false;
    public GameObject floor_piece;
    public GameObject floor_piece2;

    public GameObject building_piece;
    

	// Use this for initialization
	void Start () {
        isinhabited = false;
        
	}
	
	// Update is called once per frame
	void Update () {
        

        if (transform.position.y < 0){
            this.transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Time.deltaTime);
        }



        if (Input.GetKeyDown(KeyCode.E) && isinhabited){
            switch (gameObject.name)
            {
                case "Cube0":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y +3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10)){
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else { 
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z + 2) , transform.rotation);
                    }
                    break;
                case "Cube1":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y + 3, transform.position.z), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z), transform.rotation);
                    }
                    break;
                case "Cube2":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z - 2), transform.rotation);
                    }
                    break;
                case "Cube3":
                    if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece, new Vector3(transform.position.x , transform.position.y - 1, transform.position.z + 2), transform.rotation);
                    }
                    break;
                case "Cube5":
                    if (Physics.Raycast(new Vector3(transform.position.x , transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece, new Vector3(transform.position.x , transform.position.y - 1, transform.position.z - 2), transform.rotation);
                    }
                    break;
                case "Cube6":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece, new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z + 2), transform.rotation);
                    }
                    break;
                case "Cube7":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z ), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece, new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z ), transform.rotation);
                    }
                    break;
                case "Cube8":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece, new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z - 2), transform.rotation);
                    }
                    break;
            }
        }


        if (Input.GetKeyDown(KeyCode.E) && isinhabited)
        {
            switch (gameObject.name)
            {
                case "Cube0":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y + 3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece2, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z + 2), transform.rotation);
                    }
                    break;
                case "Cube1":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y + 3, transform.position.z), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece2, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z), transform.rotation);
                    }
                    break;
                case "Cube2":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece2, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z - 2), transform.rotation);
                    }
                    break;
                case "Cube3":
                    if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece2, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z + 2), transform.rotation);
                    }
                    break;
                case "Cube5":
                    if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece2, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z - 2), transform.rotation);
                    }
                    break;
                case "Cube6":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece2, new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z + 2), transform.rotation);
                    }
                    break;
                case "Cube7":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece2, new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z), transform.rotation);
                    }
                    break;
                case "Cube8":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        Debug.Log("What are you doing there is already an object there!");
                    }
                    else
                    {
                        GameObject.Instantiate(floor_piece2, new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z - 2), transform.rotation);
                    }
                    break;
            }
        }


        if (Input.GetKeyDown(KeyCode.R) && isinhabited)
        {
            switch (gameObject.name)
            {
                case "Cube0":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y + 3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        GameObject.Instantiate(building_piece, new Vector3(transform.position.x + 2, transform.position.y + 2, transform.position.z + 2), transform.rotation);
                    }
                    break;
                case "Cube1":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y + 3, transform.position.z), transform.TransformDirection(Vector3.down), 10))
                    {
                        GameObject.Instantiate(building_piece, new Vector3(transform.position.x + 2, transform.position.y + 2 , transform.position.z), transform.rotation);
                    }
                    
                    break;
                case "Cube2":
                    if (Physics.Raycast(new Vector3(transform.position.x + 2, transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        GameObject.Instantiate(building_piece, new Vector3(transform.position.x + 2, transform.position.y + 2 , transform.position.z - 2), transform.rotation);
                    }
                    break;
                case "Cube3":
                    if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        GameObject.Instantiate(building_piece, new Vector3(transform.position.x, transform.position.y +2, transform.position.z + 2), transform.rotation);
                    }
                    break;
                case "Cube5":
                    if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        GameObject.Instantiate(building_piece, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z - 2), transform.rotation);
                    }
                    break;
                case "Cube6":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z + 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        GameObject.Instantiate(building_piece, new Vector3(transform.position.x - 2, transform.position.y + 2, transform.position.z + 2), transform.rotation);
                    }
                    break;
                case "Cube7":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z), transform.TransformDirection(Vector3.down), 10))
                    {
                        GameObject.Instantiate(building_piece, new Vector3(transform.position.x - 2, transform.position.y + 2, transform.position.z), transform.rotation);
                    }
                    break;
                case "Cube8":
                    if (Physics.Raycast(new Vector3(transform.position.x - 2, transform.position.y + 3, transform.position.z - 2), transform.TransformDirection(Vector3.down), 10))
                    {
                        GameObject.Instantiate(building_piece, new Vector3(transform.position.x - 2, transform.position.y + 2, transform.position.z - 2), transform.rotation);
                    }
                    break;
            }
        }






    }

  

void OnTriggerEnter(Collider coll){
        if (coll.gameObject.tag.Equals("Player")) {
            isinhabited = true;
        }
    }

void OnTriggerExit(Collider coll){
        if (coll.gameObject.tag.Equals("Player")){
            isinhabited = false;
        }
    }

}



