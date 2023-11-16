using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl_select3 : MonoBehaviour
{
   public void lvl_3()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
   }
}
