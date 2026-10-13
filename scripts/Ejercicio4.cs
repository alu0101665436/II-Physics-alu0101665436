using UnityEngine;

/*
 * ================================ EJERCICIO 4 ================================
 * Crea tres tipos de objetos en capas distintas: jugador, enemigos, recolectables. 
 * Configura la Layer Collision Matrix (Project Settings > Physics). Haz que los enemigos 
 * solo colisionen con el jugador, y que los recolectables solo sean detectados por triggers.
 * =============================================================================
 */
public class Ejercicio4 : MonoBehaviour {
  // Detección de coleccionables
  void OnTriggerEnter(Collider other) {
    if (other.gameObject.layer == LayerMask.NameToLayer("Collectable")) {
      Debug.Log("¡¡Coleccionable encontrado!!");
    }
  }

  // Detección de Enemigos
  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy")) {
      Debug.Log("¡¡Enemigo encontrado!!");
    }
  }
}
