using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EditionButton : MonoBehaviour
{
    public int R;
    public int V;
    public int B;
    public Material material;
    public int index;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<Toggle>().isOn == true)
        {
            R= (int)GameObject.Find("Rouge").GetComponent<Slider>().value;
            V = (int)GameObject.Find("Vert").GetComponent<Slider>().value;
            B = (int)GameObject.Find("Bleu").GetComponent<Slider>().value;
            material.color =new Color(0.01f*R, 0.01f * V, 0.01f * B);
            GameObject[] patriciaInstances = GameObject.FindGameObjectsWithTag("PatriciaMesh");
            foreach (GameObject mesh in patriciaInstances){
                mesh.transform.GetComponent<Renderer>().materials[index].color= new Color(0.01f * R, 0.01f * V, 0.01f * B);
            }


            
        }
    }

    public void changeColor()
    {
        material.color = Color.red;
        Debug.Log("changement de couleur");
    }
}
