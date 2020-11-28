using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwitcher : MonoBehaviour
{
    [Tooltip("sprite spawners with ball")]
    [SerializeField] Sprite spriteWithBall;
    [Tooltip("sprite spawners without ball")]
    [SerializeField] Sprite spriteWithoutBall;
    [Tooltip("sprite spawners defender")]
    [SerializeField] Sprite spriteDefender;
    [Tooltip("set the time to defend")]
    [SerializeField] float timeToWait = 1f;

    SpriteRenderer show;
    enum PlayerMode {withBall,withoutBall,defender};
    PlayerMode playerMode;

    // Start is called before the first frame update
    void Start()
    {
        show = GetComponent<SpriteRenderer>();
        playerMode = PlayerMode.withoutBall;
    }

    public void SwitchToDefenderPlayer()
    {
        if(playerMode == PlayerMode.withoutBall)    //check if we can change the player mode to defender.
        {
            playerMode = PlayerMode.defender;
            show.sprite = spriteDefender;
            StartCoroutine(TimerToDisableDefender());
        }
    }

    public void SwitchToWithBallPlayer()
    {
        if (playerMode == PlayerMode.withoutBall)    //check if we can change the player mode to with ball.
        {
            playerMode = PlayerMode.withBall;
            show.sprite = spriteWithBall;
        }
    }

    public void SwitchToWithoutBallPlayer()
    {
            playerMode = PlayerMode.withoutBall;
            show.sprite = spriteWithoutBall;
    }

    public IEnumerator TimerToDisableDefender()
    {
        Debug.Log("before waiting!!!");
        yield return new WaitForSeconds(timeToWait);    // wait "X" time (1sec default), to wait before change mode. 
        if(playerMode == PlayerMode.defender)
        {
            SwitchToWithoutBallPlayer();
        }
    }
}
