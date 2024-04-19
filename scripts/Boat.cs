using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public static Boat instance;
    public float speed = 5;
    public float horizontalInput;
    private float BoatClick = 0;
    // Start is called before the first frame update

    void Awake(){
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TrashCounter.instance.currentTrash >= 2)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);

        }

        if(transform.position.x >= -46)
        {
            Destroy(gameObject);
        }
       
    }

    void OnMouseDown()
    {
        if(speed >= 5){
            speed -= 2;
            BoatClick = +1;
            Debug.Log(BoatClick);
        }
      
    }
}
