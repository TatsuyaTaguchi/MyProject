using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    int a;

    [SerializeField]
    int b;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.localPosition;

        var r = Random.Range(0, 5);
//        UnityEngine.

    }
}
