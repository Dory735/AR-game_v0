using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Edition : MonoBehaviour
{
    public Material[] objectMaterials;
    public GameObject editionButton;
    public Transform parent;
    public GameObject currentButton;
    // Start is called before the first frame update
    void Start()
    {
        float x=56;
        float y=90;
        objectMaterials = GetComponent<Renderer>().materials;
        for(int i = 0; i < objectMaterials.Length; i++)
        {
            

            currentButton =Instantiate(editionButton,parent);
            currentButton.transform.position = new Vector3(x, y,0);
            if ((i+1) % 3 == 0)
            {
                x = 56;
                y += 50;
            }
            else
            {
                x += 200;
            }
            //currentButton.transform.GetChild(0).GetComponent<TextMeshPro>().text=objectMaterials[i].ToString();
            currentButton.GetComponent<EditionButton>().material = objectMaterials[i];
            currentButton.transform.GetChild(1).GetComponent<Text>().text = objectMaterials[i].name;




        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
