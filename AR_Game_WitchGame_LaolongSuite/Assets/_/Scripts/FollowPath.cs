using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FollowPath : MonoBehaviour
{

    public PathCreator pathCreator;
    public float speed = 1.0f;
    float distanceTravelled;


    //Ce code permet de gérer un objet de tel sorte qu'il suive un chemin prédéfini
    //Pour cela on va la position et la rotation du chemin à un temps donner et les attribuer 
    //à l'objet et cela à chaque frame
    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
}
