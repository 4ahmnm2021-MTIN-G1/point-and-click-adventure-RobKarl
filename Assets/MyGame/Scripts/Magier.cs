using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magier : MonoBehaviour
{
    public string Name = "Robert";
    public int Age = 17;
    public float Height = 1.79f;
    public bool IsWearingGlasses = true;
    public Camera Cam;
    public BoxCollider Bc;
    public Rigidbody Rb;
    //public Text NeuerText;
    // Start is called before the first frame update
    void Start()
    {
        Age = 200;
        Name = "Rob";
        Bc.isTrigger = true;
        Rb.useGravity = false;
        Rb.mass = 80;
        //NeuerText.text = "Wilfred Gruber";
        //NeuerText.fontSize = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
