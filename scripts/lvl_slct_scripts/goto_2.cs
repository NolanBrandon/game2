using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl_select2 : MonoBehaviour
{
   public void lvl_2()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
   }
}
