using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class menubutton : MonoBehaviour
{
   public void mainmenu()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
   }
}
