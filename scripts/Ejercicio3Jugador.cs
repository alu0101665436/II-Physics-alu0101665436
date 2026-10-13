using UnityEngine;
 
/*
 * ================================ EJERCICIO 3 ================================
 * Crea una zona (por ejemplo, un cubo grande con Is Trigger = true). Al entrar, 
 * cambia el color del personaje o activa un efecto que cambie la luz. Al salir, 
 * revierte el cambio. Añade otra zona que aumente una variable daño.
 * =============================================================================
 */
public class Player : MonoBehaviour {
  public int damage;  //< Daño recibido

  // Iniciamos el daño a 0
  void Start() {
    damage = 0;  
  }    
}
