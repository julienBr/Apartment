using System.Collections.Generic;
using UnityEngine;

public class iPad : MonoBehaviour, IUsable
{
    [SerializeField] private List<Material> _materialList;
    [SerializeField] private List<GameObject> _canvasList;
    public void UseObject()
    {
        foreach (GameObject canvas in _canvasList)
        {
            canvas.GetComponent<MeshRenderer>().material = _materialList[Random.Range(0, _canvasList.Count)];
        }
    }
}