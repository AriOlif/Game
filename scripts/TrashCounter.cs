using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashCounter : MonoBehaviour
{
    public static TrashCounter instance;
    public TMP_Text trashText;
    public int currentTrash = 0;



    void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        trashText.text = "TRASH: " + currentTrash.ToString();
    }

    public void IncreaseTrash(int v){
        currentTrash += v;
        
        
            trashText.text = "TRASH: " + currentTrash.ToString();
        
        
    }


    // Update is called once per frame
    void Update()
    {
        /*if(currentTrash == 5)
        {
            Debug.Log("good for you");
        }*/
    }
}
