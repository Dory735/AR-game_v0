using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static int flag = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //Lance la scène du menu d'accueil quand l'application s'ouvre pour la première fois
        if (SceneManager.GetActiveScene().buildIndex ==  0 && flag==0)
        {
            ++flag;
            SceneManager.LoadScene(1);
            SceneManager.UnloadSceneAsync(0);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Qaund le bouton start est déclenché la scène du menu est désactivée et la scène de jeu activée
    public void startGame()
    {
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(1);
        flag++;
    }
}
