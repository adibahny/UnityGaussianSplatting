using System;
using UnityEngine;

public class GaussianSplatAsset : ScriptableObject
{
    [HideInInspector] public int m_SplatCount;
    [HideInInspector] public Vector3 m_BoundsMin;
    [HideInInspector] public Vector3 m_BoundsMax;

    [HideInInspector] public Texture2D m_TexPos;
    [HideInInspector] public Texture2D m_TexRot;
    [HideInInspector] public Texture2D m_TexScl;
    [HideInInspector] public Texture2D m_TexCol;
    [HideInInspector] public Texture2D m_TexSH1;
    [HideInInspector] public Texture2D m_TexSH2;
    [HideInInspector] public Texture2D m_TexSH3;
    [HideInInspector] public Texture2D m_TexSH4;
    [HideInInspector] public Texture2D m_TexSH5;
    [HideInInspector] public Texture2D m_TexSH6;
    [HideInInspector] public Texture2D m_TexSH7;
    [HideInInspector] public Texture2D m_TexSH8;
    [HideInInspector] public Texture2D m_TexSH9;
    [HideInInspector] public Texture2D m_TexSHA;
    [HideInInspector] public Texture2D m_TexSHB;
    [HideInInspector] public Texture2D m_TexSHC;
    [HideInInspector] public Texture2D m_TexSHD;
    [HideInInspector] public Texture2D m_TexSHE;
    [HideInInspector] public Texture2D m_TexSHF;

    [HideInInspector] public ChunkInfo[] m_Chunks;
    [HideInInspector] public CameraInfo[] m_Cameras;

    [Serializable]
    public struct BoundsInfo
    {
        public Vector3 pos;
        public Vector3 scale;
        public Vector4 colorOp;
        public Vector3 sh1;
        public Vector3 sh2;
        public Vector3 sh3;
        public Vector3 sh4;
        public Vector3 sh5;
        public Vector3 sh6;
        public Vector3 sh7;
        public Vector3 sh8;
        public Vector3 sh9;
        public Vector3 shA;
        public Vector3 shB;
        public Vector3 shC;
        public Vector3 shD;
        public Vector3 shE;
        public Vector3 shF;
    }

    [Serializable]
    public struct ChunkInfo
    {
        public BoundsInfo boundsMin;
        public BoundsInfo boundsInvSize;
    }

    [Serializable]
    public struct CameraInfo
    {
        public Vector3 pos;
        public Vector3 axisX, axisY, axisZ;
        public float fov;
    }
}
