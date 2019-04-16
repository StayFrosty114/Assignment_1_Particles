using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_ToggleController : MonoBehaviour
{
    // UI Variables
    public Toggle acidToggle;
    public Toggle bloodToggle;
    public Toggle blackiceToggle;
    public Toggle hellfireToggle;
    public Toggle fangToggle;
    public Toggle terrorToggle;

    // Object Variables
    public GameObject acidTrap;
    public GameObject bloodBurst;
    public GameObject blackIce;
    public GameObject hellfire;
    public GameObject fangs;
    public GameObject terror;

    // Start is called before the first frame update
    void Start()
    {
        // Setting all toggles and spell objects off at start.
        acidToggle.isOn = false;
        bloodToggle.isOn = false;
        blackiceToggle.isOn = false;
        hellfireToggle.isOn = false;
        fangToggle.isOn = false;
        terrorToggle.isOn = false;

        acidTrap.SetActive(false);
        bloodBurst.SetActive(false);
        blackIce.SetActive(false);
        hellfire.SetActive(false);
        fangs.SetActive(false);
        terror.SetActive(false);
    }

    void FixedUpdate()
    {
        // Toggling the relevant objects when the player clicks on the spells.
        if (acidToggle.isOn == true)
            acidTrap.SetActive(true);
        else if (acidToggle.isOn == false)
            acidTrap.SetActive(false);

        if (bloodToggle.isOn == true)
            bloodBurst.SetActive(true);
        else if (bloodToggle.isOn == false)
            bloodBurst.SetActive(false);

        if (blackiceToggle.isOn == true)
           blackIce.SetActive(true);
        else if (blackiceToggle.isOn == false)
            blackIce.SetActive(false);

        if (hellfireToggle.isOn == true)
            hellfire.SetActive(true);
        else if (hellfireToggle.isOn == false)
            hellfire.SetActive(false);

        if (fangToggle.isOn == true)
           fangs.SetActive(true);
        else if (fangToggle.isOn == false)
            fangs.SetActive(false);

        if (terrorToggle.isOn == true)
            terror.SetActive(true);
        else if (terrorToggle.isOn == false)
            terror.SetActive(false);


    }
}
