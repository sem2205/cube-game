using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IndividualControl : MonoBehaviour
{

    private Camera myCam;    
    bool MouseActive = false;
    public float RotationSpeed = 1.0f;
    public float lerpDuration = 1000f;
    public int MouseCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        myCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        //Cube will spin when mouse is pressed down
        if (Input.GetMouseButton(0))
        {
            if (MouseActive == true)
            {
                   StartCoroutine(RotateCubes());

                }
        }
       
    }
    //Called when user has pressed the mouse button down while over an object
    void OnMouseDown()
    {
        MouseActive = true;
        MouseCount = MouseCount + 1;
    }

    void OnMouseUp()
    {
        MouseActive = false;
    }
    IEnumerator RotateCubes()
    {
               
        float timeElapsed = 0;
                
        while (timeElapsed < lerpDuration)
        {
            if (MouseCount % 2 == 1)
            {
                this.transform.Rotate(Vector3.up * (RotationSpeed+10f) * Time.deltaTime);
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            if (MouseCount % 2 == 0)
            {
                this.transform.Rotate(0,0,0);
                timeElapsed = lerpDuration+1;
            }

        }
       
    }
}


