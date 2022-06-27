using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{
    [SerializeField] int StationID;
    [SerializeField] string StationName;
    [SerializeField] Dictionary<int, string> StationConnections;

    public Station(int id, string name, Dictionary<int, string> connections)
    {
        StationID = id;
        StationName = name;
        StationConnections = connections;
    }
}
