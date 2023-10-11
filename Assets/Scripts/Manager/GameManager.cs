using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	public GameState state;
	public Player player;
    public int startingPlatform;
	public float xSpawnOffset;
	public float minYSpawnPos;
	public float maxYSpawnPos;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
