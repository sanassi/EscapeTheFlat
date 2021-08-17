using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porteouverture2 : MonoBehaviour
{
    public float speed;
    public float speed2;
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
      float movement2 = speed2 * Time.deltaTime;
      currentValue += movement;
      if (currentValue <= maxOpenValue)
      {
         door.position = new Vector3(
          door.position.x + movement, 
          door.position.y, 
          door.position.z - movement2);
      }
      else
      {
         opening = false;
      }

     

      
        
    }
}
