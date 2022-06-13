using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Ranking1 : MonoBehaviour
{
    public string[] rank = default;

    public Ranking1(string[] _rank)
    {
        this.rank = _rank;
    }

}
