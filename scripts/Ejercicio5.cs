using UnityEngine;

/**
 * ================================ EJERCICIO 5 ================================
 * Crea una escena con distintos materiales físicos (resbaladizo, rugoso, rebote alto). 
 * Aplica distintos Physic Materials a objetos. Lanza los objetos con AddForce() al 
 * pulsar la tecla X y observa cómo cambian las reacciones.
 * =============================================================================
 */
public class Ejercicio5 : MonoBehaviour {
  private Rigidbody rb_;     //< RigidBody del Objeto a desplazar.
  private float impulse_;
  
  void Start() {
    rb_ = GetComponent<Rigidbody>();
    impulse_ = 2;
  }

  void FixedUpdate() {
    // Obtenemos dirección de aceleración
    Vector3 direction = HandleLaunch();
   
    // Normalizamos dirección
    direction.Normalize();

    // Aceleración del objeto
    rb_.AddForce(direction * impulse_, ForceMode.Impulse);
  }
  
  Vector3 HandleLaunch() {
    // Gestión del input
    bool xPressed = Input.GetKey(KeyCode.X);

    // Impulso
    return new Vector3(
      0.0f,
      xPressed? 1.0f : 0.0f,
      xPressed? 0.5f : 0.0f
    );
  }
}
