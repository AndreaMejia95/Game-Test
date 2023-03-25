<h1 align="center"><em> :video_game: Test - Game:video_game:</em></h1>


## :pencil: Diseño del nivel :pencil:
- `Nivel 1`: Este pequeño nivel de exploración es un juego de mundo abierto donde está rodeado de vegetación, rocas, una pequeña cueva y una vieja cabaña.

<img src="https://user-images.githubusercontent.com/121190130/227738705-3a388214-e671-4954-bc1d-0a6160e34054.png" width=300>  <img src="https://user-images.githubusercontent.com/121190130/227738729-266b073b-3ab1-4e9a-a436-f75172110278.png" width=300>  <img src="https://user-images.githubusercontent.com/121190130/227738737-d13d6ff2-edfa-41bc-9856-af83a32fc31a.png" width=300>


## :hammer: Mecánicas del juego :hammer:

- `Mecánica 1 - Movimientos`: El personaje puede correr, girar y saltar.
- `Mecánica 2 - Toma de ítems`: El personaje puede tomar los ítems tan pronto entra en contacto con ellos.
- `Mecánica 3 - Inventario`: Al momento en que el personaje toma los ítems estos se pueden almacenar en el sistema de inventario para luego poder usarlo
- `Mecánica 4 - Uso de ítems`: Luego de tener recolectados los ítems, el personaje puede acceder al inventario y seleccionar el ítem que desee usar posicionándose éste en su mano derecha.
- `Mecánica 5 - Apertura del Cofre`: Cuando el personaje ingresa el ítem dentro de la zona del cofre este lo detecta y lo activa dentro de él hasta contar los 5 ítems para luego proceder a abrirse y terminar el juego.
- `Mecánica 6 - Personalización`: Se puede acceder a la personalización visual del personaje con el botón que se encuentra en la esquina superior derecha entrando a un sistema donde se puede: <br>
  Poner un sombrero 👒<br>
  Poner unas gafas de sol 🕶<br>
  Poner un canguro 🎒<br>
  Cambiar el color de su camiseta 🎨<br>
  Cambiar el color de su pantalón corto 🎨

- `Mecánica 7 - Logueo`: Este sistema está creado usando la Api de PlayFab en donde registra no sólo los nuevos usuarios sino también puede loguear al usuario, comprueba la contraseña ingresada y permite el restablecimiento de contraseña con el correo usado para el previo registro llegando a la bandeja de entrada del usuario el enlace para asignar la nueva contraseña. 


## :sound: Efectos de sonido y ambientación :musical_score:
- `Sonido 1 - Items`: Al momento en que el personaje entra en contacto con los recolectables se reproduce un sonido de alerta
- `Sonido 2 - Botones`: Al momento en que el usuario pasa el cursor sobre un botón o da click se reproduce un corto sonido
- `Sonido 3 - Inventario`: Cuando se oprime la techa "I" para activar o desactivar el inventario
- `Sonido 4 - Agregar ítem`: Cuando se ingresa un ítem al cofre
- `Sonido 5 - Apertura cofre`: Se reproduce el audio final acompañando el baile del personaje
- `Sonido 6 - General`: Ambientación con sonidos naturales para sumergir al usuario en el entorno 

## 🔮 Animación 🔮
Idle y caminar 🚶‍♂️<br>
Correr 🏃‍♂️<br>
Saltar 🤸‍♂️<br>
Tomar objetos 👨‍🌾<br>
Bailar cuando se abre el cofre 💃

## :clapper: Interfáz de usuario UI :clapper:
- Posee un diseño de logueo donde cuenta con dos espacios para digitar correo y contraseña, también posee 3 botones donde uno es para ingresar, otro para registrarse y el tercero para recuperar la contraseña.
- La vista de accesorios permite la personalización de los ítems mencionados anteriormente mediante botones
- El inventario posee la selección de ítems siendo estos botones que activan el item a usar
- Los canvas de textos permiten obtener indicaciones del progreso en el juego
- El Winner posee un botón que permite cerrar el juego

<img src="https://user-images.githubusercontent.com/121190130/227737883-d9796f25-fcbe-4a6a-9294-c3fec78ef65d.png" width=300><br>
<img src="https://user-images.githubusercontent.com/121190130/227737712-6a5986c0-e642-4fc3-8786-ab6de4d59d2f.png" width=300>  <img src="https://user-images.githubusercontent.com/121190130/227737766-dcef2a0d-ba90-4dbf-9e09-47876d41c3c1.png" width=300><br>

<img src="https://user-images.githubusercontent.com/121190130/227738057-534e083a-9f8e-4d77-84ef-3c37fe3baf0d.png" width=300>  <img src="https://user-images.githubusercontent.com/121190130/227738062-c0e34fab-2c27-4dc9-846d-a7253b848bd4.png" width=300>  <img src="https://user-images.githubusercontent.com/121190130/227738061-b0bd9aa3-7ea6-4f94-afa3-aaf7a5e3e9f4.png" width=300>  <br>

<img width="300" src="https://user-images.githubusercontent.com/121190130/227738812-fef6776e-998d-4124-b050-2768bedc0c11.png">  <img width="300" src="https://user-images.githubusercontent.com/121190130/227738815-269f0d77-b51f-41d4-b5d2-9472302b6b3f.png">  <img width="300" src="https://user-images.githubusercontent.com/121190130/227738820-f7679978-5aeb-4ea7-83ed-9ca1b1f443e3.png">


## 🛠️ Abre y ejecuta el proyecto 🛠️
Para descargar el proyecto y poder visualizar el nivel en su totalidad deberá descargar los siguientes assets debido a que estos superan los 100MB de subida por git. <br>
- 🖱[Halloween Props](https://assetstore.unity.com/packages/3d/environments/fantasy/detailed-halloween-props-vol-1-236945)<br>
- 🖱[Altar Ruins](https://assetstore.unity.com/packages/3d/environments/fantasy/altar-ruins-free-109065)<br>
- 🖱[Rocks and builders 2](https://assetstore.unity.com/packages/3d/props/exterior/rock-and-boulders-2-6947)<br>
- La carpeta que contiene todo el proyecto como scripts, items etc se llama "Project Complete" y la visualizas así: <br>
<img src="https://user-images.githubusercontent.com/121190130/227738637-0c0b9969-f6ee-48ee-bf50-a6d5e3e3b6f2.png" width=300>

## Más información 📜
- Aquí podrás encontrar el GamePlay del proyecto, puedes verlo en calidad HD para una mejor visualización de la imágen: <br>
📺 [Video Demo](https://youtu.be/uiqEz1dLV3g) 📺


[<img src="https://user-images.githubusercontent.com/104279565/209356707-1a7b8815-ff11-42dd-bdc2-8bc90fb27ea9.png" width=130>
<br>Andrea Mejia<br><sub>Cuenta Principal GitHub</sub>](https://github.com/AndreaM-95)
