using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl_selectback : MonoBehaviour
{
   public void lvl_back()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
   }
}
