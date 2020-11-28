using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChooser : MonoBehaviour
{
    //https://docs.unity3d.com/2018.3/Documentation/ScriptReference/UI.Button-onClick.html
    public Button m_Expert, m_Hard, m_Normal,m_Easy1;
    
    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_Expert.onClick.AddListener(load_Expert);
        m_Hard.onClick.AddListener(load_Hard);
        m_Normal.onClick.AddListener(load_Normal);
        m_Easy1.onClick.AddListener(load_easy);
    }

    void load_Expert()
    {
        SceneManager.LoadScene("Expert", LoadSceneMode.Single);
    }
    void load_Hard()
    {
        SceneManager.LoadScene("Hard", LoadSceneMode.Single);
    }
     void load_Normal()
    {
        SceneManager.LoadScene("Normal", LoadSceneMode.Single);
    }
    void load_easy()
    {
        SceneManager.LoadScene("Easy1", LoadSceneMode.Single);
    }


}
