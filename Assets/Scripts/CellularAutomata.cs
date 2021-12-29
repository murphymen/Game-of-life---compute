using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellularAutomata : MonoBehaviour
{
    public int width = 256;
    public int height = 256;

    ComputeBuffer _worldBuffer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AllocateBuffers()
    {
        _worldBuffer = new ComputeBuffer(width * height, sizeof(CellType));
    }

    void OnDestroy()
    {
        if (_worldBuffer != null)
        {
            _worldBuffer.Release();
        }
    }
}
