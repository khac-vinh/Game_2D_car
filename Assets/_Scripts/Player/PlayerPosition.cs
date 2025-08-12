using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.tvOS;
using UnityEngine.UIElements;

public class PlayerPosition : MonoBehaviour
{

    private List<GameObject> minions ;
    public GameObject minionPrefab;
    protected float spawnTime = 0f;
    protected float spawnDelay = 1f;
    private void Start()//khoi tai bien minions
    {
        minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.spawn();
        CheckMinionDead();

    }
    void spawn()
    {
        this.spawnTime += Time.deltaTime;
        if (this.spawnTime < this.spawnDelay) return;
        this.spawnTime = 0f;

        if(this.minions.Count > 7 ) { return; }
        int index = this.minions.Count + 1;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "Bom #"+index;
        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);
        this.minions.Add(minion);

    }
    void CheckMinionDead()
    {
        //GameObject minion;
        for (int i = 0; i < this.minions.Count ; i++)
        {
            //minion = this.minions[i];
            if (this.minions[i] ==null) this.minions.RemoveAt(i);

        }
    }
 
}
