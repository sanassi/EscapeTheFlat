using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porteouverture : MonoBehaviour
{
    public float speed;
    public Transform door;
    public float maxOpenValue;
    private float currentValue = 0;
    public bool opening = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (opening == true)
          { 
            OpenDoor ();
          }
      
        
    }

    void OnTriggerEnter(Collider obj)
    {
       if (obj.transform.name == "Hero")
           {
              opening = true;
              
           }
    }
    
 

    void OpenDoor()
    {
      float movement = speed * Time.deltaTime;
      currentValue += movement;
      if (currentValue <= maxOpenValue)
      {
         door.position = new Vector3(
          door.position.x + movement, 
          door.position.y, 
          door.position.z + movement );
      }
      else
      {
         opening = false;
      }

     

      
        
    }

   
}
