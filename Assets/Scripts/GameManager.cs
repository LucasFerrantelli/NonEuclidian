using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct CameraKit
{
    public Camera camera;
    public Material cameraMaterial;
}

public class GameManager : MonoBehaviour {

    [SerializeField]
    public List<CameraKit> kits;
    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < kits.Count; i++)
        {
            if (kits[i].camera.targetTexture != null)
            {
                kits[i].camera.targetTexture.Release();
            }
            kits[i].camera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
            kits[i].cameraMaterial.mainTexture = kits[i].camera.targetTexture;
        }

        //if (cameraA.targetTexture != null)
        //{
        //    cameraA.targetTexture.Release();
        //}
        //cameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        //cameraMatA.mainTexture = cameraA.targetTexture;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
