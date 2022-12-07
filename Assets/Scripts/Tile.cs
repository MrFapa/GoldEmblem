using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TileTypes;
using TileTopping;
    public class Tile  {
        Vector2 position;
        TileType type;
        TileToppingType topping;
        bool isWalkable;

        public Vector2 Position { get => position; set => position = value; }
        public TileType Type { get => type; set => type = value; }
        public TileToppingType Topping { get => topping; set => topping = value; }

        public Tile(Vector2 position, TileType type, TileToppingType topping, bool isWalkable) {
            this.isWalkable = (type == TileType.land || type == TileType.coast && topping == TileToppingType.nothing) ? true : false;
        }

    }
