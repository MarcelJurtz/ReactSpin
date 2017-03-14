/*
* Copyright (C) Marcel Jurtz
* twitter.com/MarcelJurtz
*/
using UnityEngine;

public class GameManager : MonoBehaviour {

    #region Variables
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

	#endregion

	#region Methods
	public void endGame()
    {
        if (gameHasEnded) return;

        gameHasEnded = true;
        rotator.enabled = false;
        spawner.enabled = false;
    }
	#endregion
}
