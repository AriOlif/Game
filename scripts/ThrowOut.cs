using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowOut : MonoBehaviour
{
    //bool colliding = false;
    //DestroyIt.int value;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.CompareTag("Player"))
         {
            //colliding = true;
            TrashCounter.instance.IncreaseTrash(-1);
            TrashCanCounter.instance.IncreaseTrashCan(1);
         } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
         {
            //colliding = false;
        
         } 
    }
}
