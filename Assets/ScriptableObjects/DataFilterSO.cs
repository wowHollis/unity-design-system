using System;
using System.Reflection.Emit;
using UnityEngine;


[CreateAssetMenu(fileName = "DataFilterSO", menuName = "Scriptable Objects/DataFilterSO")]
public class DataFilterSO : ScriptableObject
{
    [Serializable]
    public struct Area
    {
        public string label;
        public string code;

        public Process[] processes;
    }

    [Serializable]
    public struct Process
    {
        public string label;
        public string code;
    }

    [SerializeField]public Area[] areas;

    public DataFilterSO()
    {
        areas = new Area[4];
    }
    
    
}
