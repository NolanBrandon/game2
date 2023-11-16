using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl_select4 : MonoBehaviour
{
   public void lvl_4()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }
}

