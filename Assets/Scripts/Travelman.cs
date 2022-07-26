using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Travelman : MonoBehaviour
{
    List<Station> Stations;
    UnityEvent m_DropdownEvent = new UnityEvent();


    void Start()
    {
        m_DropdownEvent.AddListener(DropdownAction);
    }

    
    void Update()
    {
        // If dropdown activated
        //      Invoke m_DropdownEvent.
    }


    void DropdownAction()
    {
        // Get and handle new dropdown selection.
        Debug.Log("Dropdown_Action");
    }

    List<Station> GetStations()
    {
        List<Station> list = new List<Station>();

        

        return list;
    }

}
