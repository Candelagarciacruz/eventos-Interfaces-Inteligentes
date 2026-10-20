# eventos-Interfaces-Inteligentes

## Ejercicio 1

Se han creado cinco esferas de dos tipos (tipo 1 y tipo 2), un cubo y un cilindro. El cilindro es el notificador, ya que cuando el cilindro colisiona con el cubo, se lanza el evento `onCollision`, al que se suscriben las esferas, las observadoras, mediante `+=`. Cada esfera ejecuta su función callback `React()` y decide su movimiento según su tipo: las rojas se dirigen hacia una esfera verde, elegida en el inspector, y las verdes hacia el cilindro. Se utiliza el patrón Observador para separar la notificación del evento de la respuesta de los objetos.
Además, se ha asociado otro script al cilindro para que se mueva con las flechas y así hacer que colisione con el cubo más fácilmente. A continuación se muestra su ejecución:
<img width="1894" height="924" alt="Ejer1" src="https://github.com/user-attachments/assets/ba482bcf-cc44-4db6-b928-e64f8e0baef4" />

## Ejercicio 2

Se han sustituido las figuras geométricas por personajes humanoides Footman y Lich, manteniendo el sistema de eventos y el patrón Observador. Se han añadido `Capsule Collider` a los personajes y `Rigidbody` para gestionar el movimiento y las colisiones. Durante las pruebas, se ajustaron los colliders para evitar que los personajes se atascaran al chocar con el suelo. Se mantuvo el código usado anteriormente con `Rigidbody.MovePosition()` en `FixedUpdate()` para moverlos hacia sus objetivos. Resultados de ejecución:
<img width="1900" height="980" alt="Ejer2 (1)" src="https://github.com/user-attachments/assets/255d1b9b-b918-45da-919f-15955feb5258" />


## Ejercicio 3

Se ha adaptado la escena anterior para utilizar humanoides de tipo 1 y tipo 2, junto con escudos de ambos tipos. El cubo detecta las colisiones y lanza eventos para que cada grupo se dirija al escudo correspondiente, utilizando el patrón Observador. Se han añadido `Collider` y `Rigidbody` para gestionar las colisiones físicas y el movimiento. Cuando un humanoide colisiona con un escudo, este cambia de color mediante la propiedad Tint del material ya que era la única propiedad que tenía dicho elemento que permite cambiar el color.
Al colisionar el cubo con los humanoides de tipo 2 los de tipo 1 se mueven hacia el escudo seleccionado y si colisiona con los de tipo 1 los de tipo 2 se mueven de forma aleatoria hacia un escudo de tipo 2. Se puede observar al ejecutarlo:
<img width="1912" height="930" alt="Ejer3" src="https://github.com/user-attachments/assets/5e4c875f-7fe3-4108-9874-3930fe4c1178" />

## Ejercicio 4

El cubo activa la reacción al entrar en la zona de proximidad del objeto de referencia, un cilindro en este caso, los humanoides del grupo 1 se teletransportan a un escudo previamente asignado y los del grupo 2 se orientan hacia un objeto de referencia de la escena. Para la orientación se ha usado `Quaternion.LookRotation()`. Se tienen los siguientes scripts:
- `ReferenceObjectNotifies` que detecta la proximidad y comunica el evento mediante eventos.
- `HumanoidesObserve` que ejecuta la acción correspondiente según el tipo de humanoide.
<img width="1904" height="1028" alt="Ejer4" src="https://github.com/user-attachments/assets/f33c836d-2458-4bef-924f-a3134ea1f8ae" />

## Ejercicio 5

Un jugador va recolectando escudos y se va mostrando su puntuación por la consola, teniendo en cuenta que los escudos de tipo 1 suman 5 puntos y los de tipo 2 suman 10 puntos. Una vez el jugador los recoja los escudos desaparecen. Para este ejercicio se tiene `ScoresAccumulator` que gestiona y muestra la puntuación y `ShieldCollector` la recogida. Se usa el método `Awake` para que la puntuación empiece siempre en 0 al ejecutar la escena.
Se muestra su ejecución:
<img width="1912" height="980" alt="Ejer5" src="https://github.com/user-attachments/assets/aec06b4e-f6a7-4bc4-a10c-97d1fae89731" />

## Ejercicio 6

Ahora en lugar de únicamente por la consola también se va a mostrar la puntuación en la propia escena. Para ello, se crea una interfaz Canvas con un texto TextMeshPro. Inicialmente la puntuación comienza en 0 y se va actualizando a medida que el jugador recolecta escudos:
<img width="1918" height="976" alt="Ejer6" src="https://github.com/user-attachments/assets/18e18767-31f9-469d-8379-69cd48fdaaa9" />

## Ejercicio 7

Se comprueba la puntuación acumulada del jugador y cada 100 puntos se obtiene una recompensa que se muestra en la interfaz mediante TextMeshPro. La puntuación y las recompensas también se registran en la consola.
A continuación se muestra su ejecución:<img width="1912" height="1034" alt="Ejer7" src="https://github.com/user-attachments/assets/3157f440-f527-49f7-8c79-3367ac83b498" />

## Ejercicio 8

Se ha generado a una escena incluyendo columnas y muros que se ajustan a la escena del prototipo y sirven como obstáculos del juego. Se puede observar aquí:
<img width="1914" height="1058" alt="Ejer8" src="https://github.com/user-attachments/assets/3f63826f-531f-4f22-833b-34ec1e671269" />

## Ejercicio 9

Este ejercicio es el mismo que el ejercicio 3 ya que en este el cubo tiene que ser físico.
<img width="1912" height="930" alt="Ejer3" src="https://github.com/user-attachments/assets/5e4c875f-7fe3-4108-9874-3930fe4c1178" />
