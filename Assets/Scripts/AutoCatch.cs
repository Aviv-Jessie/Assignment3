using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ModeSwitcher))]
public class AutoCatch : MonoBehaviour
{
    [SerializeField] public float timerToDefender = 1.5f;
    private ModeSwitcher modeNow;
    // Start is called before the first frame update
    void Start()
    {
        modeNow = GetComponent<ModeSwitcher>();
        StartCoroutine(TimerToDefender());
    }

     private IEnumerator TimerToDefender()
     {
         while(true)
        {
            yield return new WaitForSeconds(timerToDefender);
            modeNow.SwitchToDefenderPlayer();
        }
     }

}
