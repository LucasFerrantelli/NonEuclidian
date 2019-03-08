using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public static ScenesLoader Instance;
    public GameObject player;

    public List<GameObject> starters;
    public List<PortalCamera> portalCameras;

    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        

        for (int i = 0; i < 4; i++)
        {
            SceneManager.LoadScene(i + 1, LoadSceneMode.Additive);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(starters.Count == 4 && portalCameras[0].portal == null)
        {
            for (int i = 0; i < 4; i++)
            {
                portalCameras[i].portal = starters[i].transform;
            }
        }
    }
}
