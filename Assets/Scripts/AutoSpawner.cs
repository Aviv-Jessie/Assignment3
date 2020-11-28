using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ModeSwitcher))]
[RequireComponent(typeof(Spawner))]
public class AutoSpawner : MonoBehaviour
{
    [Tooltip("thrown the ball to eny target")]
    [SerializeField] public Transform target = null;
    [Tooltip("speed to thrown")]
    [SerializeField] public float speed = 0.5f;
    private ModeSwitcher modeNow;
    private Spawner spawner;


    // Start is called before the first frame update
    void Start()
    {
        modeNow = GetComponent<ModeSwitcher>();
        spawner = GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
         if(modeNow.GetPlayerMode() == ModeSwitcher.PlayerMode.withBall)
         {
            //credit https://answers.unity.com/questions/856122/how-could-i-use-addforce-towards-another-object-wi.html
            if(target != null)
                spawner.velocityOfSpawnedObject = (target.position - transform.position) * speed;
            modeNow.SwitchToWithoutBallPlayer();
        }
    }
}
