using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardChoosing : MonoBehaviour
{
    public GameObject[] PlayerCardHolder;
    public GameObject[] PlayerCards;
    public GameObject[] Cards;
    public GameObject[] NPCcardholder;

    public static List<GameObject> NPCcards = new List<GameObject>();
    public static List<GameObject> NPCcardchooseref = new List<GameObject>();

    public GameObject Cardspanel;
    public GameObject Canvass;
    public GameObject NPCsec;
    public GameObject Playersec;
    public GameObject Predicsec;
    public GameObject Controlsec;

    private int incr = 0;
   

    public void Start()
    {
        PlayerCards = new GameObject[4];
        
    }

   
    public void Clicked(int a)
    {
        if (incr <= 3)
        {
            Cards[a].transform.position = PlayerCardHolder[incr].transform.position;
            Cards[a].transform.SetParent(Playersec.transform);
            PlayerCards[incr] = Cards[a];
            Cards[a].GetComponent<Button>().enabled = false;
            Cards[a].transform.position += new Vector3(0, 0, 1f);
            NPCcardchooseref.Add(Cards[a]);
            incr++;
        }
       
        if(incr == 4)
        {
            Cardspanel.SetActive(false);

            int rand = Random.Range(0, 4);
            GameObject retund = Instantiate(PlayerCards[rand], NPCcardholder[0].transform.position, Quaternion.identity, NPCsec.transform);
            NPCcardchooseref.Add(retund);
            NPCcards.Add(retund);
            NPCcardchooseref[rand].transform.position += new Vector3(0, 0, 1f);
            retund.GetComponent<Button>().enabled = false;

            for (int i = 1; i < 4; i++)
            {
                int rad = Random.Range(0, 7);

                if (!NPCcardchooseref.Contains(Cards[rad]))
                {
                    NPCcardchooseref.Add(Cards[rad]);
                    GameObject returned = Instantiate(Cards[rad], NPCcardholder[i].transform.position, Quaternion.identity, NPCsec.transform);
                    returned.GetComponent<Button>().enabled = false;
                    returned.transform.position += new Vector3(0, 0, 1f);
                    NPCcards.Add(returned);
                }
                else
                {
                    i--;
                }

            }

            NPCsec.SetActive(false);
            Controlsec.SetActive(true);
            incr++;
        }

        
    }
}
