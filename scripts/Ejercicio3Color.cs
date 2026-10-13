using UnityEngine;

/**
 * ================================ EJERCICIO 3 ================================
 * Crea una zona (por ejemplo, un cubo grande con Is Trigger = true). Al entrar, 
 * cambia el color del personaje o activa un efecto que cambie la luz. Al salir, 
 * revierte el cambio. Añade otra zona que aumente una variable daño.
 * =============================================================================
 */
public class ColorZone : MonoBehaviour {
  private Color oldColor_; //< Se guarda el color original para restaurarlo

  // Cambio de Iluminación
  void OnTriggerEnter(Collider other) {
    // Solo afecta al jugador
    if (other.CompareTag("Player")) {
      Renderer renderer = other.GetComponent<Renderer>();
      
      // Se guarda el color original
      oldColor_ = renderer.material.color;
      
      // Se cambia el color
      renderer.material.color = Color.red;
    }
  }
  
  // Se restaura la iluminación
  void OnTriggerExit(Collider other) {
    // Solo afecta al jugador
    if (other.CompareTag("Player")) {
      Renderer renderer = other.GetComponent<Renderer>();

      // Se restaura el color
      renderer.material.color = oldColor_;
    }
  }
}
