using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct CellType
{
    Vector2Int position;
    Vector2 velocity;
    float density;
    float pressure;
    float temperature;
    bool processed;
    int type;
    int state;
    int age;
};
