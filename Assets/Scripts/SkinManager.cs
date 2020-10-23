using System.IO;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public void SetSkin(string name)
    {
    }

    public void GetSkins()
    {
        DirectoryInfo dir = new DirectoryInfo("Assets/PlayerSkins/Images/");
        FileInfo[] info = dir.GetFiles("*.jpg");
        foreach (FileInfo f in info)
        {
            Debug.Log(f.Name);
        }
    }
}