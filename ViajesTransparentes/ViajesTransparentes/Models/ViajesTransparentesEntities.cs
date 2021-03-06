﻿/**
* Copyright 2014 Nicotina Estudio
* 
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
* 
*     http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
**/

using System.Data.Entity;

namespace ViajesTransparentes.Models
{
    public class ViajesTransparentesEntities :DbContext
    {
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Viaje> Viajes { get; set; }
        public DbSet<ServidorPublico> ServidoresPublicos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<Viatico> Viaticos { get; set; }
        public DbSet<GrupoJerarquico> GruposJerarquicos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}