using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl_select : MonoBehaviour
{
   public void lvl_pick()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
   }
}
