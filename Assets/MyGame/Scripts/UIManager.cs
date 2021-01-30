using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   public InteractableObject activeIO;
   [SerializeField] GameObject leverRedGO;
   [SerializeField] GameObject doorRedGO;
   [SerializeField] GameObject leverPurpleGO;
   [SerializeField] GameObject doorPurpleGO;
   [SerializeField] GameObject leverOrangeGO;
   [SerializeField] GameObject doorOrangeGO;
   [SerializeField] GameObject moveAreaRedGO;
   [SerializeField] GameObject moveAreaPurpleGO;
   [SerializeField] GameObject moveAreaOrangeGO;
   [SerializeField] GameObject cable01GO;
   [SerializeField] GameObject cable02GO;
   [SerializeField] GameObject cable03GO;
   public int cableNumber;
   [SerializeField] GameObject greenDoorGO;
   [SerializeField] GameObject endAreaGO;
   [SerializeField] GameObject endSceneGO;

   public void Use()
   {
      if(activeIO.gameObject!=null)
      {
        //Levers and Doors
          if(activeIO.gameObject==leverRedGO)
         {
             doorRedGO.SetActive(false);
             moveAreaRedGO.SetActive(true);
         }
          if(activeIO.gameObject==leverPurpleGO)
         {
             doorPurpleGO.SetActive(false);
             moveAreaPurpleGO.SetActive(true);
         }
          if(activeIO.gameObject==leverOrangeGO)
         {
             doorOrangeGO.SetActive(false);
             moveAreaOrangeGO.SetActive(true);
         }


        //Cables
        if(activeIO.gameObject==cable01GO)
         {
            cable01GO.SetActive(false);
            cableNumber +=1;
         }
         if(activeIO.gameObject==cable02GO)
         {
            cable02GO.SetActive(false);
            cableNumber +=1;
         }
         if(activeIO.gameObject==cable03GO)
         {
            cable03GO.SetActive(false);
            cableNumber +=1;
         }

         //End
         if(activeIO.gameObject==endAreaGO)
         {
             endSceneGO.SetActive(true);
         }
      }
   }

    private void Update()
    {
        if(cableNumber==3)
        {
            greenDoorGO.SetActive(false);
            endAreaGO.SetActive(true);
        }
    }
}
