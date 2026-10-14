using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [System.Serializable]
    public class PointState
    {
        public PointState(GameObject gameObject, Vector3 position, Quaternion rotation)
        {
            this.gameObject = gameObject;
            this.position = position;
            this.rotation = rotation;
        }
        public GameObject gameObject;
        public Vector3 position;
        public Quaternion rotation;
    }

    public List<PointState> point_states = new List<PointState>();


    void Start()
    {
        for (int i = 0; i < transform.childCount; i++) {
            var t = transform.GetChild(i);
            point_states.Add(new PointState(t.gameObject, t.position, t.rotation));
        }
    }

    
    void Update()
    {
        
    }

    private void Reset()
    {
        for (int i = 0; i < point_states.Count; i++)
        {
            point_states[i].gameObject.transform.position = point_states[i].position;
            point_states[i].gameObject.transform.rotation = point_states[i].rotation;
        }
    }

    public void OnResetButtonDown()
    {
        Debug.Log("OnResetButtonDown");
        Reset();
    }
}
