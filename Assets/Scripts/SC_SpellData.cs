using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SpellData")]
public class SC_SpellData : ScriptableObject
{
    // Name of the Spell.
    [SerializeField]
    private string spellName;

    public string SpellName
    {
        get { return spellName; }
    }

    // Cost in Insanity Points.
    [SerializeField]
    private string drain;

    public string Drain
    {
        get { return drain; }
    }

    // Cooldown before spell can be cast again.
    [SerializeField]
    private string cooldown;

    public string Cooldown
    {
        get { return cooldown; }
    }

    // Description of spell's effect.
    [SerializeField]
    private string description;

    public string Description
    {
        get { return description; }
    }

    // Referencing the appropriate particle system.
    [SerializeField]
    private GameObject particleEffect;

    public GameObject ParticleEffect
    {
        get { return particleEffect; }
    }
}
