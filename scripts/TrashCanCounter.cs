using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashCanCounter : MonoBehaviour
{
    public static TrashCanCounter instance;
    public TMP_Text trashCanText;
    public int currentTrashCan = 0;

    void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        trashCanText.text = "TRASHCAN: " + currentTrashCan.ToString();
    }

    public void IncreaseTrashCan(int v){
        currentTrashCan += v;
        trashCanText.text = "TRASHCAN: " + currentTrashCan.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
