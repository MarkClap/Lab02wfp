# 📘 Proyecto WPF – Lab02wpf  

Este proyecto es una aplicación de escritorio desarrollada en **WPF (Windows Presentation Foundation)** con C#.  

El sistema simula un **control de ingresos, conductores, mantenimiento y reportes** de una empresa de transporte.  

---

## 🚀 Características principales  

- **Login de acceso**  
  - Usuario por defecto: `user`  
  - Contraseña por defecto: `user123`  
  - Se permite registrar nuevos usuarios (simulados en memoria).  

- **Menú principal**  
  - Botones centrados que permiten navegar entre las opciones.  
  - Se puede volver al menú desde cada ventana.  

- **Módulos principales**  
  1. **Operaciones**  
     - Registro de ingresos (documento, placa, turno, conductor, cliente, peso, etc.).  
  2. **Mantenimientos**  
     - Registro de conductores.  
     - Lista de conductores registrados (simulada).  
  3. **Reportes**  
     - Listado de cargas, ingresos y salidas.  
     - Filtros de búsqueda por:  
       - Fecha inicio  
       - Fecha fin  
       - Placa  
       - Nombre del conductor  
       - Nombre del producto  

---

## 🖼️ Estructura de ventanas  

- **MainWindow.xaml** → Login  
- **RegisterWindow.xaml** → Crear usuario  
- **MenuWindow.xaml** → Menú principal  
- **IngresosWindow.xaml** → Registro de ingresos  
- **ConductoresWindow.xaml** → Registro de conductores  
- **ListaConductoresWindow.xaml** → Listado de conductores  
- **ReportesWindow.xaml** → Listado con filtros (fecha, placa, conductor, producto)  

---

## 📂 Requisitos  

- Visual Studio 2019/2022  
- .NET Framework 4.7.2 (o superior)  
- Sistema operativo Windows  

---

## ▶️ Ejecución  

1. Clona o descarga el proyecto.  
2. Ábrelo en **Visual Studio**.  
3. Compila el proyecto (`Ctrl + Shift + B`).  
4. Ejecuta con **F5**.  
5. Ingresa con el usuario por defecto:  

   ```
   Usuario: user
   Contraseña: user123
   ```

---

## 📊 Simulación de datos  

- Los usuarios, conductores e ingresos son **simulados en memoria**, no se guarda en base de datos.  
- Los reportes cargan datos de ejemplo que se pueden filtrar en la ventana de reportes.  

---
