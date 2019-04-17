using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_SpellBook : MonoBehaviour
{
    public SC_SpellData spellData;

    // UI Variables
    public Text nameText;
    public Text drainText;
    public Text cooldownText;
    public Text descText;
    // For assigning the relevant particle system.
    public GameObject particle;


   
    public void SpellInfo()
    {
        // Setting the UI text equal to the spellData values.
        nameText.text = spellData.spellName;
        drainText.text = spellData.drain;
        cooldownText.text = spellData.cooldown;
        descText.text = spellData.description;
    }

}
