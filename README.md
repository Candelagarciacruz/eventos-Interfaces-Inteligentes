# eventos-Interfaces-Inteligentes

## Ejercicio 1

Se han creado cinco esferas de dos tipos (tipo 1 y tipo 2), un cubo y un cilindro. El cilindro es el notificador, ya que cuando el cilindro colisiona con el cubo, se lanza el evento `onCollision`, al que se suscriben las esferas, las observadoras, mediante `+=`. Cada esfera ejecuta su función callback `React()` y decide su movimiento según su tipo: las rojas se dirigen hacia una esfera verde, elegida en el inspector, y las verdes hacia el cilindro. Se utiliza el patrón Observador para separar la notificación del evento de la respuesta de los objetos.
Además, se ha asociado otro script al cilindro para que se mueva con las flechas y así hacer que colisione con el cubo más fácilmente. A continuación se muestra su ejecución:
<img width="1894" height="924" alt="Ejer1" src="https://github.com/user-attachments/assets/ba482bcf-cc44-4db6-b928-e64f8e0baef4" />

## Ejercicio 2

Se han sustituido las figuras geométricas por personajes humanoides Footman y Lich, manteniendo el sistema de eventos y el patrón Observador. Se han añadido `Capsule Collider` a los personajes y `Rigidbody` para gestionar el movimiento y las colisiones. Durante las pruebas, se ajustaron los colliders para evitar que los personajes se atascaran al chocar con el suelo. Se mantuvo el código usado anteriormente con `Rigidbody.MovePosition()` en `FixedUpdate()` para moverlos hacia sus objetivos. Resultados de ejecución:
<img width="1904" height="972" alt="Ejer2" src="https://github.com/user-attachments/assets/62493b99-feb5-41f4-ad95-4757a6cb3ef6" />

## Ejercicio 3

Se ha adaptado la escena anterior para utilizar humanoides de tipo 1 y tipo 2, junto con escudos de ambos tipos. El cubo detecta las colisiones y lanza eventos para que cada grupo se dirija al escudo correspondiente, utilizando el patrón Observador. Se han añadido `Collider` y `Rigidbody` para gestionar las colisiones físicas y el movimiento. Cuando un humanoide colisiona con un escudo, cambia de color y detiene su movimiento.
