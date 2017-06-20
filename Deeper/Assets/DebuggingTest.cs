using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggingTest : Deeper_Component {

    private Deeper_TaskManager myTM;

    private void Awake()
    {
        base.Initialize( 5000);
    }

    private void Start()
    {
        myTM = GameObject.Find("Managers").GetComponent<Deeper_TaskManager>();
    }

    public override void EarlyUpdate()
    {
        base.EarlyUpdate();
        Debug.Log("Early Update");
    }

    public override void NormUpdate()
    {
        base.NormUpdate();
        Debug.Log("Normal Update");
    }

    public override void PostUpdate()
    {
        base.PostUpdate();
        Debug.Log("Post Update");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Deeper_ServicesLocator.instance.PauseToggle();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Task t = new TestTask();
            t.Then(new TestTask()).Then(new TestTask()).Then(new TestTask());
            myTM.AddTask(t);
        }
    }
}
