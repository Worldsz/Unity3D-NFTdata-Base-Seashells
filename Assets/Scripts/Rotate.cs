using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	
		 public float xspeed = 0.0f;
		public float yspeed = 0.0f;
		public float zspeed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       transform.Rotate(
            xspeed * Time.deltaTime,
            yspeed * Time.deltaTime,
            zspeed * Time.deltaTime
       );
   
        
    }
}
