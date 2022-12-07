using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TileTypes;

namespace TileTopping
{

    public enum TileToppingType
    {
        stone,
        tree,
        nothing
    }
    public class TileToppingFunctions
    {
        public static bool isBreakable(TileToppingType type)
        {
            return (type == TileToppingType.tree) ? true : false;
        }
        public static bool isWalkable(TileToppingType tileTopping)
        {
            TileToppingType[] walkable = { TileToppingType.nothing };
            return walkable.Contains(tileTopping);
        }

        public TileToppingType getRandomTopping(TileType type)
        {
            TileToppingType[] landToppings = { TileToppingType.stone, TileToppingType.tree, TileToppingType.nothing };
            TileToppingType[] waterToppings = { TileToppingType.stone, TileToppingType.nothing };

            if (TileTypeFunctions.isLandType(type))
            {
                return landToppings[Random.Range(0, landToppings.Length)];
                
            }
            return landToppings[Random.Range(0, waterToppings.Length)];
        }
    }
}