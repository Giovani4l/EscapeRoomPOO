# Escape Room POO 🎮

## Descripción
Escape Room POO es un videojuego de escritorio desarrollado en **C#** utilizando **Windows Forms** y **.NET 8**. El proyecto está enfocado en aplicar los principios fundamentales de la **Programación Orientada a Objetos (POO)** para crear una experiencia de juego interactiva, escalable y modular.

En este juego, el jugador debe resolver acertijos de lógica, matemáticas y lenguaje para escapar a través de **5 niveles** de dificultad creciente.

---

## 👥 Autores
- **Axel Giovani Gonzalez Lopez** 
- **Raúl de Jesús Berlanga Martínez** 

---

## ✨ Características Principales
- **5 Niveles:** Dificultad creciente con un límite de tiempo de 60 segundos por nivel.
- **Internacionalización:** Soporte nativo para **8 idiomas** (ES, EN, FR, DE, IT, JA, KO, ZH) implementado sin librerías externas.
- **Sistema de Guardado:** Persistencia de datos mediante **JSON** con soporte para hasta 5 ranuras de guardado.
- **Tipos de Acertijos:**
    - 🧮 **Matemático:** Operaciones aritméticas aleatorias que escalan en dificultad.
    - 🧠 **Lógica:** Razonamiento general y conceptos de POO con un multiplicador de bonificación.
    - 🅰️ **Completar Palabra:** Oraciones incompletas enfocadas en conceptos de programación.
- **Sistema de Puntaje:** Cálculo dinámico basado en velocidad, precisión y uso de pistas.

---

## 🏗️ Arquitectura y Diseño POO
El proyecto destaca por una arquitectura limpia diseñada para ser extensible:
- **Herencia:** Clases concretas (`AcertijoMatematico`, `AcertijoLogica`, etc.) heredan de la clase abstracta `Acertijo`.
- **Abstracción:** Definición de contratos (`ValidarRespuesta`) en la clase base para asegurar consistencia.
- **Polimorfismo:** Uso de colecciones polimórficas (`List<Acertijo>`) en la interfaz de juego.
- **Interfaces:** Implementación de `IResoluble` para desacoplar el contrato de la implementación lógica.
- **Encapsulamiento:** Gestión rigurosa de estados, respuestas correctas privadas y configuración centralizada.
- **Responsabilidad Única:** Separación clara entre lógica de UI (`FormJuego`), datos y persistencia (`RepositorioPartidas`).

---

## 📊 Sistema de Puntaje
La puntuación se calcula bajo la siguiente fórmula:

`Puntos = PuntosBase + (SegundosRestantes * 2) - Penalización`

*   **Bonus Velocidad:** Resolver rápidamente maximiza los puntos obtenidos.
*   **Penalización:** El uso de pistas descuenta puntos (`PuntosBase / 3`).
*   **Bonus Lógica:** Los acertijos de lógica aplican un multiplicador de `x1.2` al total calculado.

---

## 💾 Sistema de Guardado (JSON)
Se implementó un sistema manual de serialización/deserialización para gestionar partidas, permitiendo al usuario:
- Pausar y guardar el progreso durante el juego.
- Cargar partidas guardadas previamente mediante un formulario dedicado.
- Eliminar partidas antiguas para gestionar las 5 ranuras disponibles.

---

## 🌐 Idiomas Soportados
La internacionalización fue lograda mediante una clase estática `IdiomaJuego` y `switch expressions` de C# 8, asegurando un rendimiento óptimo:
- 🇲🇽 Español
- 🇬🇧 English
- 🇫🇷 Français
- 🇩🇪 Deutsch
- 🇮🇹 Italiano
- 🇯🇵 日本語
- 🇰🇷 한국어
- 🇨🇳 中文

---

## 🛠️ Tecnologías Utilizadas
- **Lenguaje:** C#
- **Framework:** .NET 8
- **Interfaz:** Windows Forms
- **Persistencia:** JSON (Serialización manual sin dependencias externas)
