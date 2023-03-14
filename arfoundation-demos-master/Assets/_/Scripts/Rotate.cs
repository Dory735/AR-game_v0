using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 50f; // Vitesse de rotation

    // Update est appel� � chaque frame
    void Update()
    {
        // Appliquer une rotation � l'objet sur l'axe Y
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
