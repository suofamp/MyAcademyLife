using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeoneGenerator : MonoBehaviour
{
    public GameObject someonePrefab;
    List<(float, float)> someoneGene = new List<(float, float)>();
    SomeonePointer someonePointer;

    public void SetUp(SomeonePointer someonePointer)
    {
        someoneGene = someonePointer.someonePoints;
        Debug.Log(someoneGene.Count);
        for (int i = 0; i < someoneGene.Count; i++)
        {
            Instantiate(someonePrefab, new Vector2(someoneGene[i].Item1, someoneGene[i].Item2), Quaternion.identity);
        }
    }
}
