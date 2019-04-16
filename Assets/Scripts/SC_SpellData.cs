using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SpellData")]
public class SC_SpellData : ScriptableObject
{
    // Name of the Spell.
    public string spellName;

    // Cost in Insanity Points.
    public string drain;

    // Cooldown before spell can be cast again.
    public string cooldown;

    // Description of spell's effect.
    public string description;

    // Referencing the appropriate particle system.
    public GameObject particleEffect;
}
