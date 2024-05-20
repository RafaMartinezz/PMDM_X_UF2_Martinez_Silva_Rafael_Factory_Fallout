# FACTORY FALLOUT

## GAME DESIGN DOCUMENT

Creado por: Rafael Martínez Silva

Versión del documento: 1.0

## HISTORIAL DE REVISIONES

| Versión | Fecha      | Comentarios            |
|---------|------------|------------------------|
| 1.00    | 2024-05-18 | Creación del documento |

> - Mantén el orden de versión de manera creciente
> - Cada versión tendrá un comentario indicando los cambios realizados
> - Añade nuevas filas en caso necesario

## RESUMEN

### Concepto

En "Factory Fallout", el jugador debe sobrevivir y luchar contra hordas de zombis en una zona industrial.

### Puntos Clave

- **Supervivencia en un entorno hostil**: Los jugadores deben gestionar recursos, como salud, mientras se enfrentan a oleadas de zombis.
- **Exploración de la zona industrial**: Investiga fábricas y almacenes abandonados en busca de los zombies para erradicarlos.
- **Generación dinámica de enemigos**: Los zombis se generan de por zonas y no se desplazan hasta que ven al jugador.
- **Estrategia y planificación**: Planifica tus movimientos y usa el entorno a tu favor para sobrevivir el mayor tiempo posible.

### Género

Acción, Supervivencia, Estrategia.

### Público Objetivo

Jugadores de entre 16 y 35 años que disfrutan de juegos de acción y supervivencia con temática postapocalíptica. Aficionados a juegos como "Left 4 Dead", "The Last of Us", y "Resident Evil".

### Experiencia de Juego

Los jugadores experimentarán una atmósfera tensa y opresiva mientras se mueven por la zona industrial, buscando recursos y enfrentando constantes amenazas de zombis. Visualmente, el juego presentará un entorno oscuro y decadente, con sonidos ambientales que aumentan la inmersión. Los personajes podrán saltar, disparar y usar diferentes habilidades para sobrevivir.

## DISEÑO

### Metas de Diseño

- **Inmersión**: Crear un entorno de juego que sumerja al jugador en una zona industrial postapocalíptica.
  - Se logrará mediante el uso de gráficos detallados, iluminación oscura y efectos de sonido ambientales.
- **Tensión constante**: Mantener al jugador en un estado de alerta continua.
  - Generación dinámica de zombis y recursos limitados para aumentar la tensión.
- **Jugabilidad estratégica**: Fomentar la planificación y el uso inteligente del entorno.
  - Implementar mecánicas que permitan al jugador usar el entorno a su favor, como barricadas y trampas.

## MECÁNICAS DE JUEGO

### Núcleo de Juego

- **Movimiento**: Los jugadores pueden moverse libremente por el entorno y saltar.
- **Combate**: Utiliza armas de fuego.
- **Salud**: El jugador tiene una barra de salud que disminuye cuando recibe daño. Puede ser restaurada con PowerUps.
- **Detección de proximidad**: Los zombis se activan y atacan cuando el jugador está dentro de un rango específico.
- **Generación de enemigos**: Los zombis se generan en ubicaciones predefinidas.
- **Recogida de power-ups**: Los jugadores pueden encontrar power-ups que aumentan la salud o proporcionan otras ventajas.

### Flujo de Juego

1. **Inicio**: El jugador comienza en una ubicación segura dentro de la zona industrial.
2. **Exploración**: El jugador explora el entorno en busca de suministros.
3. **Encuentros**: El jugador encuentra y combate contra zombis.
4. **Recogida de power-ups**: El jugador recoge power-ups para mejorar sus posibilidades de supervivencia.
6. **Final**: El juego termina cuando el jugador mata todos los zombies de la escena.

### Fin de Juego

- **Derrota**:
  - La salud del jugador llega a cero: El juego muestra una pantalla de "Game Over" y el jugador tiene la opción de reiniciar.
- **Victoria**:
  - El jugador mata todos los zombies de la escena: El juego muestra una pantalla de "Victoria".

### Física de Juego

- **Movimiento del jugador**: Basado en la física de Unity, permite correr y saltar con una sensación de peso y realismo.
- **Colisiones**: El jugador y los enemigos tienen colisiones con el entorno y entre ellos, utilizando `Rigidbody` y `Collider` de Unity.

### Controles

| Acción         | Tecla/Comando         |
|----------------|-----------------------|
| Moverse        | W, A, S, D            |
| Saltar         | Espacio               |
| Disparar       | Botón izquierdo del ratón |

## MUNDO DEL JUEGO

### Descripción General

El juego se desarrolla en una zona industrial postapocalíptica, caracterizada por fábricas abandonadas, maquinaria oxidada y un ambiente oscuro y decadente. El entorno está lleno de obstáculos, escondites y recursos que los jugadores pueden utilizar para sobrevivir.

### Personajes

- **Jugables**:
  - **Jugador**: Un superviviente equipado con varias armas y habilidades para enfrentarse a los zombis. Tiene un diseño robusto y resistente, adecuado para el entorno hostil.
- **Enemigos**:
  - **Zombi Común**: Los enemigos básicos, lentos pero peligrosos en grupo.

### Objetos

- **Armas**:
  - **Pistola**: Arma de fuego básica con munición limitada.
- **Power-ups**:
  - **Botiquín**: Restaura la salud del jugador.

## INTERFAZ

### Flujo de Pantallas

1. **Pantalla de Juego**: Donde ocurre la acción principal.
2. **Pantalla de Fin de Juego**: Muestra el resultado de la partida (Victoria/Derrota) y opciones para reiniciar o salir.

### HUD

- **Barra de Salud**: Muestra la salud actual del jugador.
- **Mira**: Mira para apuntar con el arma.

## ARTE

### Metas de Arte

- **Estilo Oscuro y Decadente**: Crear un entorno industrial postapocalíptico con texturas detalladas y efectos de iluminación que resalten el ambiente sombrío.
- **Diseño de Personajes**: Zombies realistas que se descomponen en partes cuando son disparados y se caen al suelo cuando se mueren.
- **Animaciones Suaves**: Animaciones "realistas" para el movimiento, combate y acciones de los personajes.

### Assets de Arte

- **Personajes**:
  - Modelos y animaciones para los zombis (caminar, atacar, morir).
- **Entorno**:
  - Modelos de fábricas, maquinaria, escombros y otros elementos industriales.
- **Objetos**:
  - Power-ups.
- **Efectos**:
  - Efectos de partículas para disparos, explosiones, sangre, etc.

### Recursos descargados

- **Unity Asset Store**:

  - BloodDecalsAndEffects: Sistemas de particulas para imitar la sangre y las visceras.
  - RPG_FPS_game_assets_industrial: Texturizados, materiales y prefabs para diseñar una zona industrial.
  - Zombie by Pxltiger: Texturizados, materiales y prefabs de zombies.

## AUDIO

### Metas de Audio

- **Ambiente Inmersivo**: Crear una atmósfera sonora que sumerja al jugador en la zona industrial postapocalíptica.
- **Efectos de Sonido Realistas**: Sonidos para armas.
- **Música Tensa**: Banda sonora que aumente la tensión y la sensación de peligro constante.

### Assets de Audio

- **Música**:
  - Tema de fondo para añadir ambiente de tensión.
- **Sonidos**:
  - **Armas**: Sonido de disparo.

## DETALLES TÉCNICOS

### Plataformas Objetivo

- **PC (Windows, Mac, Linux)**
- **Especificaciones recomendadas**:
  - Procesador: Intel i5 o equivalente
  - Memoria RAM: 8 GB
  - Gráficos: NVIDIA GTX 960 o equivalente
  - Almacenamiento: 10 GB de espacio disponible

### Herramientas de Desarrollo

- **Motor de Juego**: Unity.
- **Modelado y Animación**: Blender.
- **Control de Versiones**: Gitlab.
- **Otras Herramientas**: Visual Studio Code