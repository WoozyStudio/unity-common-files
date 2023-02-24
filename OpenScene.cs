using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Important line to acces SceneManager.LoadScene

public class OpenScene : MonoBehaviour
{
    public void Scene()
    {
        SceneManager.LoadScene("SceneNameOrValue");
    }
}
