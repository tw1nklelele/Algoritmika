using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start вызывается один раз перед первым кадром
    void Start()
    {
        // Уничтожает игровой объект, к которому прикреплен этот скрипт
        Destroy(gameObject);
    }
}
