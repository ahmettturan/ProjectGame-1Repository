using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicScript : MonoBehaviour
{
    private void Start()
    {
        Invoke("AmacimizNedir", 1f);
    }
    public void AmacimizNedir() 
    {
        Debug.Log("Birlikte Unity Öğreniyoruz");    
    }    
}

// //private CoroutineDenemesi() 
// {
//     private IEnumerator coroutineObjesi;

//     private void Start() 
//     {
//         coroutineObjesi = CoroutineFoksiyon(2);
//         StartCoroutine(coroutineObjesi);
//     }
//    private IEnumerator CoroutineFoksiyon(float sure)
//    {
//         while (true)
//         {
//             yield return new WaitForSeconds(sure);
//             Debug.Log("Birlikte Unity Öğreniyoruz");
//         }
//    }
//     private void Update() 
//     {
//         if(Input.GetKeyDown("space"))
//         {
//             StopCoroutine(coroutineObjesi);
//         }    
//     }
// }