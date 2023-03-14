using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FollowPath : MonoBehaviour
{

    public PathCreator pathCreator;
    public float speed = 1.0f;
    float distanceTravelled;


    //Ce code permet de g�rer un objet de tel sorte qu'il suive un chemin pr�d�fini
    //Pour cela on va la position et la rotation du chemin � un temps donner et les attribuer 
    //� l'objet et cela � chaque frame
    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
}
