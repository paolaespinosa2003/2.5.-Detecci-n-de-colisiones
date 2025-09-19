# ES2.5. Detección de colisiones

## Descripción
Este proyecto en Unity implementa la detección de colisiones siguiendo el tutorial *Interactive Book 08 Collision Detection*.  
El objetivo es evitar que el personaje atraviese paredes o el piso, logrando interacciones coherentes con el entorno.

## Implementación
- Se creó el script **ColisionControl.cs** que detecta colisiones mediante `OnCollisionEnter2D`.
- Se asignaron colliders a los sprites (personaje, piso y paredes).
- Cuando el personaje colisiona con una pared, su movimiento se detiene.
- Los colliders se ajustaron al contorno de los sprites, evitando superposición.

## Conclusión
La escena ahora contiene detección de colisiones funcional.  
El personaje no atraviesa paredes ni piso, cumpliendo con los criterios de evaluación solicitados en la actividad.
