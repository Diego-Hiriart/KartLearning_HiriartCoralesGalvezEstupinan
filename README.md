# KartLearning_HiriartCoralesGalvezEstupinan

Tarea de Machine Learning con Karts en Unity

Programacion V
- [Diego Hiriart](https://github.com/Diego-Hiriart)
- [Luis Corales](https://github.com/LuisCorales)
- [Daniela Estupiñan](https://github.com/Daniela-Estupinan)
- [Martin Galvez](https://github.com/MGA1398)

## Detalles del entrenamiento
- Se entrenó al modelo con un solo MLAgent.
- Se realizaron cerca de 300.000 pasos para el entrenamiento.
- Se detuvo el entrenamiento cuando se observó que se estabilizaba la media de recompensas entre 150 y 300. Y la desviación estándar tendía a ser 0 constantemente.

## Implementación del Ghosting
Siguiendo el tutorial de [Karting mod: Add a Ghost Driver](https://learn.unity.com/tutorial/karting-mod-add-a-ghost-driver?uv=2019.3&projectId=5c82b27cedbc2a0e8db0c728#5ea7e9fdedbc2a00206dcaad) se implementó que por cada vuelta que el MLAgent realice, aparecerá un Ghost Driver replicando el recorrido.
