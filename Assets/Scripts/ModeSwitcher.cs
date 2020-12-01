using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Spawner))]
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
    [Tooltip("to trigger with ball")]
    [SerializeField] string ballTag = "ball";
    [Tooltip("on disqualification move to scane or just distroy the ball if is null")]
    [SerializeField] string sceneName = null;

    private SpriteRenderer show;
    public enum PlayerMode {withBall,withoutBall,defender};
    private PlayerMode playerMode;

    // Start is called before the first frame update
    void Start()
    {
        show = GetComponent<SpriteRenderer>();
        playerMode = PlayerMode.withoutBall;
    }

    public ModeSwitcher.PlayerMode GetPlayerMode()
    {
        return playerMode;
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

    public void SwitchToWithBallPlayer(GameObject ball)
    {
        if (playerMode == PlayerMode.defender)    //check if we can change the player mode to with ball.
        {
            playerMode = PlayerMode.withBall;
            show.sprite = spriteWithBall;
            Destroy(ball);
        }else{
            disqualification();
        }
    }

    public void SwitchToWithoutBallPlayer()
    {
            if(playerMode == PlayerMode.withBall) // we need thrown the ball
            {
                GetComponent<Spawner>().spawnObject();
            }
            playerMode = PlayerMode.withoutBall;
            show.sprite = spriteWithoutBall;
    }

    private void OnTriggerEnter2D(Collider2D other){ 
        if (other.tag == ballTag) //other is ball
        {
            SwitchToWithBallPlayer(other.gameObject);
        }
    }
    public void disqualification(){    
        if( !System.String.IsNullOrEmpty(sceneName) )
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }else{
            Destroy(this.gameObject);
        }
    }


    private IEnumerator TimerToDisableDefender()
    {
        yield return new WaitForSeconds(timeToWait);    // wait "X" time (1sec default), to wait before change mode. 
        if(playerMode == PlayerMode.defender)
        {
            SwitchToWithoutBallPlayer();
        }
    }
}
