using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    void Start()
    {
        int[] array = { 70, 85, 75, 130, 115 };
        for(int a = 0; a < array.Length;a++)//�z��̗v�f�̒l��\��
        {
            Debug.Log(array[a]);
        }
        for(int b = array.Length -1; b > -1; b-- )//�z��̗v�f�̒l���t���ɕ\��
        {
            Debug.Log(array[b]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
