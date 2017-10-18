using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LoadFBX : MonoBehaviour
{

    public string fileName = "";
    public string FBXfilename = "";
    public string file = "";
    public int slashCount = 0;
    // Use this for initialization
    void Start()
    {
        Doit();
    }
    public void Doit()
    {
        for (int i = fileName.Length - 1; i > 0; i--)
        {
            if (fileName[i] == '/')
            {
                Debug.Log("hello");
                slashCount += 1;
                if(slashCount == 1)
                {
                    FBXfilename += '@';
                    i--;
                }
                if(slashCount == 2)
                {
                    break;
                }
            }
            FBXfilename += fileName[i];
        }
        for (int i = FBXfilename.Length - 1; i > 0; i--)
        {
            file += FBXfilename[i];
            if(i == 1)
            {
                i--;
                file += FBXfilename[i];
            }
        }
        Debug.Log("did it");
    }

}
