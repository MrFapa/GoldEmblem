using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TileTopping
{

    public enum TileType
    {
        water,
        land,
        coast,
        undefined,
        border
    }
    public class TileTypeFunctions
    {
        public static bool isLandType(TileType type)
        {
            return (type == TileType.land || type == TileType.coast) ? true : false;
        }
    }
}