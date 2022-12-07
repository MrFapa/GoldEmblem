using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TileTypes;
using TileTopping;
public class Tile  {

    Vector2Int position;
    TileType type;
    TileToppingType topping;
    bool isWalkable;
    Tile[] neighbours;

    public Vector2Int Position { get => position; set => position = value; }
    public TileType Type { get => type; set => type = value; }
    public TileToppingType Topping { get => topping; set => topping = value; }
    public bool IsWalkable { get { return TileToppingFunctions.isWalkable(this.Topping); } }
    public Tile[] Neighbours { get => neighbours; set => neighbours = value; }

    public Tile(Vector2Int position, TileType type, TileToppingType topping) {
        this.Position = position;
        this.Type = type;
        this.Topping = topping;
        this.Neighbours = new Tile[8];
    }
}