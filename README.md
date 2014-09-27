
README Reto #ViajesTransparentes
============

Proyecto prototipo para el reto #ViajesTransparentes - IFAI

Objetivos del reto:
- Transparentar inteligentemente la información pública que se genera sobre los viajes de trabajo nacionales e internacionales de los comisionados y los servidores públicos del IFAI para fomentar un debate público informado y rendir cuentas en la materia
- Desarrollar una herramienta web de código abierto que pueda ser replicada a nivel nacional e internacional por otras instituciones públicas.
- Generar una primera práctica de reutilización de datos abiertos sobre viajes de trabajo para retroalimentar un posible primer estándar de publicación de datos abiertos en viajes de servidores públicos.
- Difundir y dar uso a la información derivada de los trabajos realizados durante los viajes para asociar su costo a los resultados que producen a la luz de las tareas sustantivas y agenda estratégica de la institución.
- Generar estadísticas y métricas sobre distintos aspectos de los viajes de trabajo, así como visualizaciones que permitan realizar comparaciones históricas, temáticas y por servidor público, y que faciliten el seguimiento y la evaluación.

Roles:
- Administrador
- Servidor Público
- Usuario

Características:
- Página de perfil de servidores públicos

Tecnología:
- SQLServer
- Entity Framework
- Code First
- Migrations
- ASP.NET MVC 5
- WEB API


##Dependencias
Las encontraras en el archívo package.config dentro del a solución.

##Instalación / Configuración 
1. Abrir la solución con el IDE (Visual Studio).
2. Cambiar los datos de la cadena de conexión a la base de datos en el archívo Web.config.
3. Abrir el Package Manager Console y ejecutar el comando "update-database".
4. Ejecutar aplicación.

##Screenshots
![Perfil Servidor Público](http://www.nicotinaestudio.com/Content/Descargas/Retos//ViajesTransparentes/Imagenes/servidores-publicos.jpg "Perfil Servidor Público")
![Detalle comisión](http://www.nicotinaestudio.com/Content/Descargas/Retos//ViajesTransparentes/Imagenes/comisiones.jpg "Detalle comisión")

##Demo
- [Demostración en línea](http://viajestransparentes.azurewebsites.net)
- [API - Servidores públicos - Todos](http://viajestransparentes.azurewebsites.net/api/ServidoresPublicos)
- [API - Servidores públicos - Id](http://viajestransparentes.azurewebsites.net/api/ServidoresPublicos/2)
- [Screencast] {#}

##¿Preguntas o problemas? 
Mantenemos la conversación del proyecto en nuestra página de problemas [issues] (https://github.com/NicotinaEstudio/viajes-transparentes/issues). Si usted tiene cualquier otra pregunta, nos puede contactar por correo <soporte@nicotinaestudio.mx>.

##Contribuye
Queremos que este proyecto sea el resultado de un esfuerzo de la comunidad. Usted puede colaborar con [código](https://github.com/NicotinaEstudio/viajes-transparentes/pulls), [ideas](https://github.com/NicotinaEstudio/viajes-transparentes/issues) y [bugs](https://github.com/NicotinaEstudio/viajes-transparentes/issues).

##Equipo
- [Carlos Isaac Hernández Morfín](https://github.com/Izakc)
- [Dulce María Soto Correo](#)


##Licencia
Copyright 2014 Nicotina Estudio

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.