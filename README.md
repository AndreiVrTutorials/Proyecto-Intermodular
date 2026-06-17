# Proyecto-Intermodular
# 🕶️ VR Patrimonio Inclusivo: Valladolid y Salamanca

[![Engine](https://img.shields.io/badge/Unity-2022.3%2B-blue?logo=unity&logoColor=white)](https://unity.com/)
[![Language](https://img.shields.io/badge/Language-C%23-green?logo=csharp&logoColor=white)](https://learn.microsoft.com/es-es/dotnet/csharp/)
[![Target Hardware](https://img.shields.io/badge/Hardware-Meta%20Quest%203-black?logo=meta&logoColor=white)](https://www.meta.com/es/quest/quest-3/)
[![Project Type](https://img.shields.io/badge/Type-Intermodular%20/%20Social-orange)](#)

Proyecto intermodular de Realidad Virtual (VR) autónoma (*Standalone*) diseñado en colaboración con el **Centro Gregorio Fernández**, la **Universidad de Valladolid (UVa)** y la **Universidad de Salamanca (USAL)**. El software permite la exploración interactiva y remota del patrimonio histórico de ambas ciudades, enfocado principalmente en romper barreras arquitectónicas para personas con diversidad funcional y dificultades motoras graves.

---

## 📌 Características Principales

* **Navegación Confortable (Anti-Motion Sickness):** Implementación de locomoción estática y controlada mediante el *joystick* del mando y rotación natural de la cabeza, mitigando los efectos de desorientación espacial.
* **Paseo de la Fama Interactivo:** Sistema de reconocimiento a personajes históricos ilustres con activación de audios por proximidad espaciada.
* **Localización Bilingüe Inmediata:** Arquitectura de traducción en tiempo de ejecución (Español/Inglés) con persistencia de configuración del usuario tras el cierre de la aplicación.
* **Entorno Envolvente 360°:** Integración de un reproductor de vídeo esférico inversa (*Skybox* mapeado) para albergar contenido multimedia inmersivo complementario.

---

## 🛠️ Stack Tecnológico

### Core & Desarrollo
* **Motor Gráfico:** Unity (Pipeline móvil optimizado, OpenXR API & Meta XR SDK).
* **Lenguaje:** C# (Programación orientada a componentes, patrones de persistencia y lógica de triggers).
* **Control de Versiones:** Unity Version Control (Plastic SCM).

### Modelado & Multimedia
* **Modelos 3D:** Activos de alta fidelidad generados por fotogrametría mediante drones de la UVa y USAL, optimizados a baja carga poligonal (*low-poly*) para VR móvil.
* **Sistemas de Partículas (VFX):** Efectos ligeros en Unity (simulación de vuelo de aves) para dinamizar el entorno sin saturar la GPU.
* **Inteligencia Artificial Generativa:** * **MeshyAI:** Modelado 3D procedural (generación de las letras volumétricas "Valladolid").
    * **ElevenLabs:** Síntesis de voz teatralizada para locuciones de audioguías bilingües.
    * **Gemini:** Optimización sintáctica de textos y guiones contextuales.

---

## 📐 Arquitectura de Escenas e Interacción

El software se segmenta de forma modular para optimizar la carga en la memoria RAM del visor:

[Menú Principal (Hub Estático)]
│
├──► [Escena Valladolid]  ──► (Canvas Espaciales + Triggers de Audio)
├──► [Escena Salamanca]   ──► (Fotogrametría low-poly + Audioguías AI)
└──► [Escena Vídeo 360°]  ──► (Mapeo Esférico Envolvente)

### Mecánicas Implementadas en C#
* **Billboarding (Textos Orientados):** Los elementos interactivos flotantes (*World Space Canvas*) rotan dinámicamente sobre su eje Y para mirar directamente a la cámara del jugador, asegurando la legibilidad.
* **Sincronización Acústica:** Lógica de interrupción y atenuación de *Audio Triggers* para evitar el solapamiento de pistas sonoras cuando el usuario se desplaza rápidamente entre puntos de interés.

---

## 📊 Métricas de Control de Calidad (Feedback Real)

El prototipo funcional fue sometido a pruebas de usabilidad y rendimiento con un grupo heterogéneo de **9 usuarios de control** (rangos de edad de 8 a 81 años). Los datos empíricos obtenidos guiaron los ajustes finales de ingeniería:

| Identificador | Perfil de Usuario | Hito de Validación | Ajuste Técnico Aplicado |
| :--- | :--- | :--- | :--- |
| **Muestra Infantil** | Escolar (8 años) | Accesibilidad y *Learnability* | Interfaces autoexplicativas sin texto técnico. |
| **Muestra Joven** | Nativo Digital (~20 años) | Rendimiento Técnico Extremo | Bloqueo térmico de partículas para evitar caídas de FPS. |
| **Muestra Laboral** | Oficina (~40-50 años) | Ergonomía Multimedia | Depuración en C# de colisiones de audio concurrentes. |
| **Muestra Senior** | Tercera Edad (81 años) | Confort Visual Crítico | Escalado tipográfico de menús y remoción de aceleraciones de cámara. |

---

## 🚀 Despliegue en Meta Quest 3

1. Habilitar el **Modo Desarrollador** en la aplicación Meta Horizon del smartphone.
2. Conectar el visor a la estación de trabajo mediante cable Link o de datos USB-C.
3. Clonar el repositorio y abrir en Unity (versión 2022.3 LTS o superior).
4. Asegurar que la plataforma de compilación esté configurada en `Android`.
5. Seleccionar las escenas en el *Build Settings* (`Menu`, `Valladolid`, `Salamanca`, `Video360`) y pulsar **Build and Run**.