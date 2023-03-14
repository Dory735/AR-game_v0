using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogToScreen : MonoBehaviour
{
    uint qsize = 15;
    Queue myLogQueue = new Queue();
    //Ce script va servir à pouvoir logger directement sur l'écran ce qui est très utile en phase de développement
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started up logging");
    }

    private void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }
    private void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString,string stackTrace,LogType type)
    {
        myLogQueue.Enqueue("[" + type + "]:" + logString);
        if (type == LogType.Exception)
            myLogQueue.Enqueue(stackTrace);
        while (myLogQueue.Count > qsize)
            myLogQueue.Dequeue();
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width - 400, 0, 400, Screen.height));
        GUILayout.Label("\n" + string.Join("\n", myLogQueue.ToArray()));
        GUILayout.EndArea();
    }


}
