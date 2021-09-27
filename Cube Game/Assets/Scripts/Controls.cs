using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour

{
    public GameObject cubePlayer;
    public List<GameObject> cubeClones;
       

    // Start is called before the first frame update
    void Start()
    {
        cubeClones = new List<GameObject>();
    }
     

    // Update is called once per frame
    void Update()
    {

        //When space bar is pressed, a new cube will be spawned into the scene
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
         Vector3 position = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10, 10f));                
         GameObject newCube = Instantiate(cubePlayer, position, Quaternion.identity) as GameObject;
         cubeClones.Add(newCube);
            Debug.Log("The length of the list of cubes is: " + cubeClones.Count);           


        }

        //When the left control key is pressed, all cubes will change a random colour
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            foreach (GameObject newCube in cubeClones)
            {
                newCube.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            }


        }
        //When left arrow is pressed, the cube moves to the left of screen incrementally
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            foreach (GameObject newCube in cubeClones)
            {
                Vector3 position = newCube.transform.position;
                position.x--;
                newCube.transform.position = position;
            }
                
        }
        //When right arrow is pressed, the cube moves to the right of screen incrementally
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            foreach (GameObject newCube in cubeClones)
            {
                Vector3 position = newCube.transform.position;
                position.x++;
                newCube.transform.position = position;
            }

        }
        //When up arrow is pressed, the cube moves upward incrementally
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            foreach (GameObject newCube in cubeClones)
            {
                Vector3 position = newCube.transform.position;
                position.y++;
                newCube.transform.position = position;
            }

        }
        //When down arrow is pressed, the cube moves downward incrementally
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            foreach (GameObject newCube in cubeClones)
            {
                Vector3 position = newCube.transform.position;
                position.y--;
                newCube.transform.position = position;
            }

        }
       
    }

   
}

