using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    [SerializeField]
    Player player;

    bool isInCombat;

    [SerializeField]
    GameAudio gameAudio;

    public Player Player { get => player; }
    public bool IsInCombat { get => isInCombat; set => isInCombat = value; }
    public GameAudio GameAudio { get => gameAudio; }

    void Awake()
    {

        if(!instance)
        {
            
            instance = this;

        } else 
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
   
    }

    private void Start()
    {
        gameAudio.AudioSource = GetComponent<AudioSource>();
        gameAudio.PlayBGMusic();
    }

    public void StartCombat()
    {

        //isInCombat = true;
        player.Anim.SetLayerWeight(1, 1);
        player.weaponVisible(true);
        gameAudio.PlayBattleMusic();

    }

    public void StopCombat()
    {

        //isInCombat = true;
        player.Anim.SetLayerWeight(0, 1);
        player.Anim.SetLayerWeight(1, 0);
        player.weaponVisible(false);
        gameAudio.PlayBGMusic();

    }

}

