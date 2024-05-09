### 2024_1_primeraPrueba_Actuacion_Clase

Se tiene de base un códgio incompleto, terminar esta solución para que cumpla con los siguientes requerimientos: 

Deben elegir una de las siguientes 3 opciones: 

a. Obtención de Perro: 
A partir de una raza se debe obtener un 200 con la raza, descripcion y si es hipoalergenico o no.

b. Creacion de Perro:
Se manda la raza, descripcion y si es hipoalergenico o no.
En caso de creación correcta se debe retornar un 201 con la raza, descripcion y si es hipoalergenico o no.

c. Obtención de token de Usuario:
Para un email y contraseña se debe retornar un 200 con el token en caso de que exista. En esta prueba va a haber un usuario único ya registrado.

- En caso de que alguna de las operaciones previas no haya sido completada, el filtro de excepciones debe encargarse de devolver el mensaje y código de error que corresponda que corresponda.

- Completar el filtro de autentificación. Recuerden que tienen funciones que pueden ser de utilidad ya implementadas en UserLogic.

- Completar el filtro de excepciones para las excepciones que sean necesarias.

- Completar el mecanismo de la inyección de las dependencias 

- Completar el test que corresponda con la funcionalidad seleccionada dentro de DogControllerTest/UserControllerTest

Notas:
- Existe un único usuario registrado en la base de datos.
- Ya tienen implementada una capa de acceso a datos con acceso a una base de datos en memoria que funciona. No deben modificar esto (no les conviene :D )
- La prueba es individual, con material con una duración de 60 minutos.
- No se olviden de pushear sus cambios antes del límite de tiempo
- En caso de no poder pushear, hagan un zip con todo el códgio y mandenlo por mensaje en team a los 2 docentes de tec.