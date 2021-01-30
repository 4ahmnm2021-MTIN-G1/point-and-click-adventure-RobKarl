using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject commandMenu;
    public UIManager uIManager;
    public Text dialogFenster;
    public string inspectText;

    public void OnMouseDown()
    {
        commandMenu.transform.position = this.transform.position;
        commandMenu.active = true;
        uIManager.activeIO=this;
        dialogFenster.text = inspectText;
    }
}