using UnityEngine;

public class AnotherObject : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(GameSettings.volume);
        GameSettings.volume = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PersistentObject.staticPublicDebugText = "A";
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(PersistentObject.staticPublicDebugText);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            PersistentObject.SetStaticPrivateText("C");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            var go = GameObject.Find("PersistenObject");
            var p = go.GetComponent<PersistentObject>();
            p.SetInstancePrivateText("D");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            PersistentObject.Getinstance().SetInstancePrivateText("E");
            PersistentObject.Getinstance().gameObject.name = "Big";
        }
    }
}
