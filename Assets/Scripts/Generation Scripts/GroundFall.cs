using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Generation_Tools;

public class GroundFall : MonoBehaviour
{
    private float Timer = 0f;
    private float div = 3f;
    private int level = 15;
    public MakeArenaArray a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        
        if(Timer/div >= 1f && level > 0)
        {
            div += 3f;
            for(int i = 0; i < (16 - level); i++)
            {
                LowerArenaLevel(15 - i);
            }
            
            level--;
        }

    }

    void LowerArenaLevel(int level)
    {
        for(int i = (level - 1); i < (30 - (level - 1)); i++)
        {
            a.arena.tileRef[i, (level - 1)].transform.position = new Vector3(a.arena.tileRef[i, (level - 1)].transform.position.x, a.arena.tileRef[i, (level - 1)].transform.position.y - 1, a.arena.tileRef[i, (level - 1)].transform.position.z);
            a.arena.tileRef[i, (30 - (level))].transform.position = new Vector3(a.arena.tileRef[i, (30 - (level))].transform.position.x, a.arena.tileRef[i, (30 - (level))].transform.position.y - 1, a.arena.tileRef[i, (30 - (level))].transform.position.z);
        }

        if (level != 15)
        {
            for (int i = level; i < (30 - (level + 1)); i++)
            {
                a.arena.tileRef[(level - 1), i].transform.position = new Vector3(a.arena.tileRef[(level - 1), i].transform.position.x, a.arena.tileRef[(level - 1), i].transform.position.y - 1, a.arena.tileRef[(level - 1), i].transform.position.z);
                a.arena.tileRef[(30 - (level)), i].transform.position = new Vector3(a.arena.tileRef[(30 - (level)), i].transform.position.x, a.arena.tileRef[(30 - (level)), i].transform.position.y - 1, a.arena.tileRef[(30 - (level)), i].transform.position.z);
            }
        }



    }

    void FlushCycle()
    {
        
    }
}
