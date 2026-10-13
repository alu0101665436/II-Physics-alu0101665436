using UnityEngine;

/**
 * ================================ EJERCICIO 3 ================================
 * Crea una zona (por ejemplo, un cubo grande con Is Trigger = true). Al entrar,
 * cambia el color del personaje o activa un efecto que cambie la luz. Al salir,
 * revierte el cambio. Añade otra zona que aumente una variable daño.
 * =============================================================================
 */
public class DamageZone : MonoBehaviour {
  public float damageTime;     //< Tiempo que tarda en hacer daño la zona
  private float timeElapsed_;  //< Tiempo transcurrido para ejercer el daño.
  private int damage_;         //< Daño a realizar al jugador.

  void Start() {
    timeElapsed_ = 0f;
    damageTime = 2f;
    damage_ = 1;
  }

  // Daño inicial
  void OnTriggerEnter(Collider other) {
    // Solo afecta al jugador
    if (other.CompareTag("Player")) {
      Player player = other.GetComponent<Player>();

      // Asignación de daño    
      if (player != null) {
        player.damage += damage_;
        timeElapsed_ = 0f;
        Debug.Log("Daño actual: " + player.damage); // Testeo
      }
    }
  }

  // Daño continuado
  void OnTriggerStay(Collider other) {
    // Solo afecta al jugador
    if (other.CompareTag("Player")) {
      Player player = other.GetComponent<Player>();

      // Asignación de daño 
      if (player != null) {
        timeElapsed_ += Time.fixedDeltaTime;

        // Cada vez que pase el tiempo hace daño
        if (timeElapsed_ >= damageTime) {
          player.damage += damage_;
          timeElapsed_ = 0f;
          Debug.Log("Daño actual: " + player.damage); // Testeo
        }
      }
    }
  }

}
