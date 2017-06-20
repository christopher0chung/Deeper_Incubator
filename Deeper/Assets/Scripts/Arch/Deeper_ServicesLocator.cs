using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deeper_ServicesLocator {

    private static Deeper_ServicesLocator _instance;
    public static Deeper_ServicesLocator instance
    {
        get
        {
            if (_instance == null)
                _instance = new Deeper_ServicesLocator();
            return _instance;
        }
    }

    public void Pause()
    {
        Deeper_GameUpdateManager.instance.PauseGame(true);
    }

    public void Unpause()
    {
        Deeper_GameUpdateManager.instance.PauseGame(false);
    }

    public void PauseToggle()
    {
        Deeper_GameUpdateManager.instance.PauseGame(!Deeper_GameUpdateManager.instance.PauseState());
    }
}
