using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballchange : MonoBehaviour
{
    public int count;
    [Header("1은 파랑")]
    public int team;
    public void Up()
    {
        count -= 1;
        while (true)
        {
            if (count == -1)
            {
                count = Gamemanager.StoneCnt - 1;
            }
            if (count == Gamemanager.StoneCnt)
            {
                count = 0;
            }
            if (Gamemanager.IsBuy[count] == true)
            {
                if (team == 1)
                {
                    Instantiate(BallSet.inc.BlueStone[count]);
                }
                else
                {
                    Instantiate(BallSet.inc.RedStone[count]);
                }
                break;
            }
            else
            {
                count -= 1;
            }
        }
                
        
        Destroy(this.gameObject);
    }

    public void Down()
    {
        count += 1;
        while (true)
        {
            if (count == -1)
            {
                count = Gamemanager.StoneCnt - 1;
            }
            if (count == Gamemanager.StoneCnt)
            {
                count = 0;
            }
            if (Gamemanager.IsBuy[count] == true)
            {
                if (team == 1)
                {
                    Instantiate(BallSet.inc.BlueStone[count]);
                }
                else
                {
                    Instantiate(BallSet.inc.RedStone[count]);
                }

                break;
            }
            else
            {
                count += 1;
            }
        }

        SoundMng.instance.PlaySe(0);
        Destroy(this.gameObject);
    }
}
