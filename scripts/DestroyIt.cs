using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIt : MonoBehaviour
{
    bool colliding = false;
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(colliding && Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
            TrashCounter.instance.IncreaseTrash(value);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.CompareTag("Player"))
         {
            colliding = true;
        
         } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
         {
            colliding = false;
        
         } 
    }
}
