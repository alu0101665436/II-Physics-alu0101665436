using UnityEngine;

/**
 * ================================ EJERCICIO 1 ================================
 *  Crea un personaje,controla su desplazamiento con las teclas WASD o las flechas, 
 *  el movimiento debe realizarse usando un Rigidbody, pero manteniendo el control total.
 * =============================================================================
 */
public class Ejercicio1 : MonoBehaviour {
  public float acceleration; //< Aceleración de movimiento del elemento rígido
  private Rigidbody rb_;     //< RigidBody del Objeto a desplazar.

  void Start() {
    acceleration = 10;
    rb_ = GetComponent<Rigidbody>();
  }
  
  void FixedUpdate() {
    // Obtenemos dirección de aceleración
    Vector3 direction = HandleDirection();
   
    // Normalizamos dirección
    direction.Normalize();

    // Aceleración del objeto
    rb_.AddForce(direction * acceleration, ForceMode.Acceleration);
  }
  
  Vector3 HandleDirection() {
    // Gestión del Input
    float horizontalMovement = Input.GetAxis("Horizontal");
    float verticalMovement = Input.GetAxis("Vertical");
    return new Vector3(
      horizontalMovement,
      0,
      verticalMovement
    );
  }
}
