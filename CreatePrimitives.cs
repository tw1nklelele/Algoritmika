using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Start вызывается один раз перед первым кадром
    void Start()
    {
        // Создаем шесть кубов в форме человеческой фигуры (Стив из Minecraft)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 3, 0);
    }
}
