using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PredCards : MonoBehaviour
{
    public GameObject[] PredCardHolder;
    public GameObject[] predictedcards;

    public List<GameObject> PredictdCards = new List<GameObject>();

    public GameObject Endsec;
    public PlayerTurn inst;
    public EnemyTurn enm;
    public CardChoosing card;
    public GameObject Frame;

    [HideInInspector]
    public string playercrd, prediccards;

    public void OnEnable()
    {
        for (int i = 0; i < 7; i++)
        {
            if (inst.enemyturn && enm.TurnCount == 1)
            {
                GameObject rtrn = Instantiate(predictedcards[i], PredCardHolder[i].transform.position, Quaternion.identity, card.Predicsec.transform);
                PredictdCards.Add(rtrn);
            }
        }


        if (inst.Pcardused != null)
        {
            playercrd = inst.Pcardused.GetComponentInChildren<TextMeshProUGUI>().text;

            for (int i = 0; i < 7; i++)
            {
                prediccards = PredictdCards[i].GetComponentInChildren<TextMeshProUGUI>().text;

                if (playercrd == prediccards)
                {
                    PredictdCards[i].SetActive(false);
                }
               
            }

            for (int j = 0; j < CardChoosing.NPCcards.Count; j++)
            {
                string enemycrd = CardChoosing.NPCcards[j].GetComponentInChildren<TextMeshProUGUI>().text;

                if (playercrd == enemycrd)
                {
                    Endsec.SetActive(true);
                    inst.Pcardused.transform.position = Frame.transform.position;
                    inst.Pcardused.transform.SetParent(Frame.transform);
                    inst.Pcardused.SetActive(true);
                    card.NPCsec.SetActive(false);
                    card.Predicsec.SetActive(false);
                    card.Controlsec.SetActive(false);
                }

            }

        }
        

    }
}
