using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Generation_Tools
{
    public class ArenaData
    {
        public Space2D terrainValues;
        public GameObject[,] tileRef;

        public ArenaData()
        {
            terrainValues = new Space2D(30, 30);
            tileRef = new GameObject[30, 30];
        }
    }
}
