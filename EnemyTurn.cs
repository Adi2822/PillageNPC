using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyTurn : MonoBehaviour
{
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject[] btns;


    public CardChoosing refer;
    public PlayerTurn trn;
    
    public int TurnCount = 1;

    [HideInInspector]
    public GameObject Ecardused;
    public PredCards pc;
    public TextMeshProUGUI turncounttxt;

    public bool ECused;

    
    public void buton5()
    {
        button8.SetActive(false);
        button7.SetActive(false);
        button6.SetActive(false);
        button5.SetActive(true);

    }
    public void buton6()
    {
        button8.SetActive(false);
        button7.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(true);

    }
    public void buton7()
    {
        button8.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        button7.SetActive(true);

    }
    public void buton8()
    {
        button5.SetActive(false);
        button7.SetActive(false);
        button6.SetActive(false);
        button8.SetActive(true);

    }

    public void desty(int b)
    {
        
        Ecardused = CardChoosing.NPCcards[b];
        CardChoosing.NPCcards[b].SetActive(false);
        btns[b].SetActive(false);
    }

    public void Enemychangeturn()
    {
        refer.Playersec.SetActive(true);
        refer.NPCsec.SetActive(false);
        refer.Predicsec.SetActive(false);

        trn.turntxt.text = "Player";
        TurnCount++;
        turncounttxt.text = TurnCount.ToString();

        trn.enemyturn = false;
    }
   
    public void skp()
    {
        
        Ecardused = null;
        
        trn.turntxt.text = "Player";
        TurnCount++;
        turncounttxt.text = TurnCount.ToString();


        refer.Playersec.SetActive(true);
       refer.NPCsec.SetActive(false);
       refer.Predicsec.SetActive(false);
    }

    //public void check()
    //{
    //    if (Ecardused != null)
    //    {
    //        string EnemCard = Ecardused.GetComponentInChildren<TextMeshProUGUI>().text;

    //        for (int i = 0; i < 7; i++)
    //        {
    //            if (EnemCard == pc.PredictdCards[i].GetComponentInChildren<TextMeshProUGUI>().text)
    //            {
    //                print("yes");
    //                pc.PredictdCards[i].SetActive(false);
    //            }
    //        }
    //    }
    //}

}
