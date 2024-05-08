- 2024_1_primeraPrueba_Actuacion_Clase

Se tiene de base un códgio incompleto, terminar esta solución para que cumpla con los siguientes requerimientos: 

- Obtención de Perro: 
A partir de una raza se debe obtener la raza, descripcion y si es hipoalergenico o no.

- Creacion de Perro:
Se manda la raza, descripcion y si es hipoalergenico o no.
En caso de creación correcta se debe retornar la raza, descripcion y si es hipoalergenico o no.

- Obtención de token de Usuario:
Para un email y contraseña se debe retornar el token en caso de que exista. En esta prueba va a haber un usuario único ya registrado.

- En caso de que alguna de las operaciones previas no haya sido completada, el filtro de excepciones debe encargarse de devolver el mensaje que corresponda.

#### De estos 3 casos previos (obtencion token, obtencion de perro o creación de perro) implementar 1 solo

- Completar el filtro de autentificación y de excepcion

- Hacer que funcione la inyección de dependencias

- Completar los dos test dentro de DogControllerTest

Notas:
- Existe un único usuario registrado en la base de datos.
- Ya tienen implementada una capa de acceso a datos con acceso a una base de datos en memoria que funciona. No deben modificar esto (no les conviene :D )
- La prueba es individual, con material, y el límite es de 45 minutos.
- No se olviden de pushear sus cambios antes del límite de tiempo