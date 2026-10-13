using UnityEngine;

/**
 * ================================ EJERCICIO 6 ================================
 * En la escena debe haber 3 objetos que tengan Collider pero no Rigidbody. Un cubo, 
 * una esfera y un cilindro que deben estar alineados. Marcar el cilindro como objetivo 
 * a alcanzar por la esfera. El cubo debe hacer de obstáculo entre ambos. Implementar un 
 * script que haga que la esfera se dirija al cilindro, cuando la esfera alcance el cubo, 
 * este debe cambiar su material.
 * =============================================================================
 */
public class Ejercicio6 : MonoBehaviour {
  public Material newMaterial;  //< Nuevo material a mostrar
  private Transform objective_; //< Objetivo a alcanzar
  private Collider obstacle_;   //< Collider del obstáculo
  private bool colisionEnter_;  //< Representa si se entra a la colisión
  private float speed_;         //< Velocidad de movimiento 
  
  // Almacena el destino
  void Start() {
    objective_ = GameObject.Find("Destino").GetComponent<Transform>();      
    obstacle_ = GameObject.Find("Obstaculo").GetComponent<Collider>();
    colisionEnter_ = true;
    speed_ = 2.0f;
  }
  
  // Se va acercando al cilindro
  void Update() {
    // Actualización de posición
    HandleMovement(
      GetComponent<Transform>()
    );

    // Detectar colisión con el obstáculo
    HandleCollisionEnter(
      GetComponent<Collider>()  
    );
  }

  private void HandleMovement(Transform actualTransform) {
    // Cálculo del offset
    Vector3 offset = objective_.position - actualTransform.position;
    offset.Normalize();
    
    // Actualización de posición
    actualTransform.Translate(
      offset * speed_ * Time.deltaTime
    ); 
  }
  
  // Detecta la colisión con el cubo
  void HandleCollisionEnter(Collider actualCollider) {
    bool inCollision = actualCollider.bounds.Intersects(obstacle_.bounds);
    
    // En caso de colisión
    if (inCollision && colisionEnter_) {
      colisionEnter_ = false;
      Renderer rd = GetComponent<Renderer>();
       rd.material = newMaterial;
    }
    
    // En otro caso
    else {
      colisionEnter_ = true;
    }
  }
}
