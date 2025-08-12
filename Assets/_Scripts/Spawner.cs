using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objPrefab;
    public List<GameObject> objects;
    public GameObject SpawnPos;
    public float spawnTime = 0f;
    public float spawnDelay = 1f;
    public int spawnCount = 0;
    public string spawnPosName = "";
    public string prefabName = "";
    public int maxObj = 1;
    public int layerOrder = 0;

    private void Awake()
    {
        this.objects = new List<GameObject>();
        this.SpawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefab = GameObject.Find(this.prefabName);
        this.objPrefab.SetActive(false);
        this.layerOrder = (int)this.objPrefab.transform.position.z;

    }
    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }
    protected virtual GameObject Spawn()
    {
        if (PlayerCtrl.instance.damageReceiver.IsDead()) return null;
        if (this.objects.Count >= this.maxObj)  return null; 

        this.spawnTime += Time.deltaTime;
        if (this.spawnTime < this.spawnDelay) return null;
        this.spawnTime = 0;

        Vector3 pos= this.SpawnPos.transform.position;
        pos.z = this.layerOrder;
        return this.Spawn(pos);
    }
    protected virtual GameObject Spawn(Vector3 pos)
    {
        GameObject obj = Instantiate(this.objPrefab);
        obj.transform.position = pos;
        obj.transform.parent = transform;
        obj.SetActive(true);

        this.objects.Add(obj);
        return obj;
    }
    protected virtual void CheckDead()
    {
        for (int i = 0; i < this.objects.Count; i++)
        {
            if (this.objects[i] == null) this.objects.RemoveAt(i);
        }
    }
}
