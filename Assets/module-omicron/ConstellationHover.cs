using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems; // Required for event systems

public class ConstellationHover : MonoBehaviour
{
 // Assign your info panel here
    public GameObject infoPanelTuc; // Assign your info panel here
    public GameObject infoPanelVul; // Assign your info panel here
    public GameObject infoPanelLMi; // Assign your info panel here
    public GameObject infoPanelAri; // Assign your info panel here
    public GameObject infoPanelLib;

    void Update()
    {
        // Check if the mouse is over a UI element
        if (EventSystem.current.IsPointerOverGameObject()) return;

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log($"Hit: {hit.collider.gameObject.name} with tag {hit.collider.tag}");
            // Check if the hit object is part of a constellation
            if (hit.collider.gameObject.CompareTag("Lib")) // Make sure your constellation lines have this tag
            {
                ShowPanelLib(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.CompareTag("Tuc")) // Make sure your constellation lines have this tag
            {
                ShowPanelTuc(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.CompareTag("Vul")) // Make sure your constellation lines have this tag
            {
                ShowPanelVul(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.CompareTag("LMi")) // Make sure your constellation lines have this tag
            {
                ShowPanelLMi(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.CompareTag("Ari")) // Make sure your constellation lines have this tag
            {
                ShowPanelAri(hit.collider.gameObject);
            }
        }
        else
        {
            HidePanel();
        }
    }
        
    

    void ShowPanelLib(GameObject hitObject)
    {
        // Position and update your panel based on the hitObject or its data
        infoPanelLib.SetActive(true);
        // Update panel information here based on the hitObject's data or associated constellation
    }
    void ShowPanelTuc(GameObject hitObject)
    {
    // Position and update your panel based on the hitObject or its data
        infoPanelTuc.SetActive(true);
        // Update panel information here based on the hitObject's data or associated constellation
    }
    void ShowPanelVul(GameObject hitObject)
    {
        // Position and update your panel based on the hitObject or its data
        infoPanelVul.SetActive(true);
        // Update panel information here based on the hitObject's data or associated constellation
    }
    void ShowPanelLMi(GameObject hitObject)
    {
        // Position and update your panel based on the hitObject or its data
        infoPanelLMi.SetActive(true);
        // Update panel information here based on the hitObject's data or associated constellation
    }
    void ShowPanelAri(GameObject hitObject)
    {
        // Position and update your panel based on the hitObject or its data
        infoPanelAri.SetActive(true);
        // Update panel information here based on the hitObject's data or associated constellation
    }


    void HidePanel()
    {
            
            infoPanelTuc.SetActive(false);
            infoPanelVul.SetActive(false);
            infoPanelLMi.SetActive(false);
            infoPanelAri.SetActive(false);
            infoPanelLib.SetActive(false);
    }
}
