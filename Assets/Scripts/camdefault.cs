using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camdefault : MonoBehaviour
{
    [SerializeField] private Transform to;
    [SerializeField] private Transform of;
    void Start()
    {
        of.rotation = to.rotation;
        of.position = to.position;
    }

   
    public void DO()
    {
        of.rotation = to.rotation;
        of.position = to.position;
    }
}
