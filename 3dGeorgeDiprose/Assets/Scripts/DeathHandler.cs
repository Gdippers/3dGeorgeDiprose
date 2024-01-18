using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gOCanvas;


    // Start is called before the first frame update
    void Start()
    {
        gOCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        gOCanvas.enabled = true;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        FindObjectOfType<Weapon>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }
}
