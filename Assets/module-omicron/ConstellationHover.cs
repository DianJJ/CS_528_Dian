using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems; // Required for event systems

public class ConstellationHover : MonoBehaviour
{
 // Assign your info panel here
    public GameObject infoPanelUMa; 
    //public GameObject infoPanelLMi;
    private bool isActionExecuted = true;
    void Start()
    {
        HidePanel();
    }
    void Update()
    {
        // Check if the mouse is over a UI element
        if (EventSystem.current.IsPointerOverGameObject()) return;

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //if (Physics.Raycast(ray, out hit))
        //{
            //Debug.Log($"Hit: {hit.collider.gameObject.name} with tag {hit.collider.tag}");
            // Check if the hit object is part of a constellation
            //if (hit.collider.gameObject.CompareTag("UMa")) // Make sure your constellation lines have this tag
            //{
                //ShowPanelUMa(hit.collider.gameObject);
            //}
            //if (hit.collider.gameObject.CompareTag("LMi")) // Make sure your constellation lines have this tag
            //{
            //    Debug.Log("hit LMi");
            //    ShowPanelLMi(hit.collider.gameObject);
            //}
        //}
        //else
        //{
            //HidePanel();
        //}
    }
        
    

    public void TogglePanelUMa()
    {
        // Position and update your panel based on the hitObject or its data
        infoPanelUMa.SetActive(isActionExecuted);
        isActionExecuted = !isActionExecuted;
        // Update panel information here based on the hitObject's data or associated constellation
    }
    //void ShowPanelLMi(GameObject hitObject)
    //{
        // Position and update your panel based on the hitObject or its data
      //  infoPanelLMi.SetActive(true);
        // Update panel information here based on the hitObject's data or associated constellation
    //}


    public void HidePanel()
    {
            
            infoPanelUMa.SetActive(false);
            //infoPanelLMi.SetActive(false);
    }
}
