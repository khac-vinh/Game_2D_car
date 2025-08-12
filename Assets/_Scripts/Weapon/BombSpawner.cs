using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.tvOS;
using UnityEngine.UIElements;

public class BombSpawner : Spawner
{
    private void Reset()
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "BombPrefab";
        this.maxObj = 6;
    }
    
}
