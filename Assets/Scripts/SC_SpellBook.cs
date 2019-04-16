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


   
    void Start()
    {
        // Setting the UI text equal to the spellData values.
        nameText.text = spellData.spellName;
        drainText.text = spellData.drain;
        cooldownText.text = spellData.cooldown;
        descText.text = spellData.description;
    }

    private void Update()
    {
        // Refreshing UI text every frame. (To fix a problem with text not updating when activating a spell that had already been activated).
        nameText.text = spellData.spellName;
        drainText.text = spellData.drain;
        cooldownText.text = spellData.cooldown;
        descText.text = spellData.description;
    }

}
