using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Levels { Splash, OpeningCutscene }

public class Deeper_Event_LevelUnload: Deeper_Event { }

public class Deeper_Event_LevelLoad: Deeper_Event
{
    public Levels level;
    public Deeper_Event_LevelLoad (Levels l)
    {
        level = l;
    }
}

public class Deeper_SceneManager {

    private Dictionary<Levels, string> _levelDict = new Dictionary<Levels, string>();

    private Deeper_SceneManager _instance;
    public Deeper_SceneManager instance
    {
        get
        {
            if (_instance == null)
                _instance = new Deeper_SceneManager();
            return _instance;
        }
    }

    public void LoadLevel (Levels lvl)
    {
        Deeper_EventManager.instance.Fire(new Deeper_Event_LevelUnload());
        if (lvl == Levels.Splash)
        {

        }
        Deeper_EventManager.instance.Fire(new Deeper_Event_LevelLoad(lvl));
    }
}
