# 🐾 Animales: Perros y Loros  

Este proyecto consiste en la creación de clases en C# que modelan animales, trabajando con **herencia, atributos y métodos específicos** para cada tipo de animal.  

## 📌 Descripción  

Se parte de una clase base `Animal`, de la cual heredan `Perro` y `Loro`.  
Cada clase incluye atributos y métodos particulares, además de funcionalidades comunes a todos los animales.  

### Clase `Animal`  
- **Atributos:**  
  - `nombre`  
  - `edad`  
  - `kilosComidaConsumida`  

- **Métodos:**  
  - `getInicial()`: retorna la inicial del nombre.  
  - `alimentar(char alimento)`: incrementa los kilos consumidos según el tipo de alimento:  
    - `a` → +1 kg  
    - `b` → +2.5 kg  
    - `c` → +3 kg  
    - En caso de un valor inválido, puede lanzar una excepción (opcional).  

### Clase `Perro` (hereda de `Animal`)  
- **Atributo:**  
  - `raza`  

### Clase `Loro` (hereda de `Animal`)  
- **Atributo:**  
  - `palabraFavorita`  

- **Método:**  
  - `aprenderPalabra(string palabra)`: si la nueva palabra es más larga que la actual, pasa a ser la favorita.  

### Opcional  
- Se puede agregar una clase extra que también herede de `Animal`.  

## 🛠️ Funcionalidades a probar  
Una vez cargados los datos por teclado:  

1. Mostrar **nombre y edad**.  
2. Preguntar cuántos años pasaron e incrementar la edad.  
3. Mostrar nuevamente **nombre y edad**.  
4. Enseñar **tres nuevas palabras** al loro y mostrar la palabra favorita.  
5. Mostrar la **raza del perro**.  
6. Alimentar dos veces a los animales y mostrar los **kilos de comida consumida**.  
7. Mostrar la **inicial** del que más comida consumió.  

---

📚 Este ejercicio sirve como práctica de:  
- Programación orientada a objetos (POO).  
- Herencia de clases.  
- Manejo de atributos y métodos.  
- Entrada por teclado y validaciones.  
