using UnityEngine;

/**
 * ================================ EJERCICIO 2 ================================
 * Crea varios cubos o esferas con Rigidbody dinámico. Muestra por consola el nombre 
 * del objeto con el que colisiona, y cámbiale su color al colisionar.
 * =============================================================================
 */
public class Ejercicio2 : MonoBehaviour {
  private Renderer renderer_; //< Renderer del rigidbody dinámico

  void Start() {
    renderer_ = GetComponent<Renderer>();    
  }
  
  // Cambio de color en colision
  void OnCollisionEnter(Collision collisionInfo) {
    // Comprobación que ha colisionado con un objeto distinto del suelo
    Rigidbody rb = collisionInfo.gameObject.GetComponent<Rigidbody>();

    // Cambio de color
    if (rb != null) {
      Debug.Log("Colisión con: " + name);
      renderer_.material.color = GenRandomColor();    
    }
  }
  
  // Genera un Color aleatorio
  private Color GenRandomColor() {
    return new Color(
      Random.Range(0.0f, 1.0f),
      Random.Range(0.0f, 1.0f),  
      Random.Range(0.0f, 1.0f),
      1.0f
    );
  }
}
