using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="BuildSettings", menuName ="Scriptable Objects/Build/Build Settings", order =1)]
public class BuildSettingsSO : ScriptableObject
{
    [Header("Butler Info")]
    public bool UploadBuild;
    public string Username;
    public string ProjectName;

    [Header("Build Info")]
    public bool UpdateBuildInfo;
    public uint BuildNumber;
}
