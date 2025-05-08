using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    public Text nameText;
    public Text attackText;
    public Text healthText;
    public Text effectText;

    public Image backgroundImage;

    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        ShowCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {
        nameText.text = card.cardName;
        if(card is MonsterCard)
        {
            var monster = card as MonsterCard;
            attackText.text =monster.attack.ToString();
            healthText.text=monster.healthMax.ToString();
            effectText.gameObject.SetActive(false);
        }
        else if(card is SpellCard)
        {
            var spell = card as SpellCard;
            effectText.text=spell.effect.ToString();
            attackText.gameObject.SetActive(false);
            healthText.gameObject.SetActive(false);
        }
    }
}
