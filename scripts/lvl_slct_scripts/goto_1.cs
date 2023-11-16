using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl_select1 : MonoBehaviour
{
   public void lvl_1()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
   }
}
