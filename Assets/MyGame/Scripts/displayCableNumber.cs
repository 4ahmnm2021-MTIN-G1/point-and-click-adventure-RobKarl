using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayCableNumber : MonoBehaviour
{
    [SerializeField] UIManager uiManagerUIM;
    int cableNumberD;
    Text intTextOB;

    private void Start()
    {
        intTextOB = GetComponent<Text>();
    }
    
    private void Update()
    {  
        cableNumberD = uiManagerUIM.cableNumber;
        if (cableNumberD==1)
        {
            intTextOB.enabled = true;
        }
        intTextOB.text = "Cables collected: "+cableNumberD.ToString();
    }
}