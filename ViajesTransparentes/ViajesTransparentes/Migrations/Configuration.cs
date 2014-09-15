namespace ViajesTransparentes.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ViajesTransparentes.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ViajesTransparentes.Models.ViajesTransparentesEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ViajesTransparentes.Models.ViajesTransparentesEntities context)
        {
//            new List<ServidorPublicoIFAI>
//            {
//                new ServidorPublicoIFAI { Institucion="INSTITUTO FEDERAL DE ACCESO A LA INFORMACI�N Y PROTECCI�N DE DATOS ORGANISMO AUT�NOMO en proceso de reestructuraci�n", Nombre="Liliana", PrimerApellido="Herrera", SegundoApellido="Mart�n", NombreCompleto="Liliana Herrera Mart�n", TipoDePersonal="Confianza", NombreDelCargo="Secretar�a Particular", NombreDelCargoSuperior="Comisionado", UnidadAdministrativa="Comisionado", ClaveDelPuesto="MC03", NombreDelPuesto="SECRETARIO PARTICULAR DE PONENCIA", CorreoElectr�nico="liliana.herrera@ifai.org.mx" },
//                new ServidorPublicoIFAI { Institucion="INSTITUTO FEDERAL DE ACCESO A LA INFORMACI�N Y PROTECCI�N DE DATOS ORGANISMO AUT�NOMO en proceso de reestructuraci�n", Nombre="Adri�n Israel", PrimerApellido="Manilla", SegundoApellido="Aguirre", NombreCompleto="Adri�n Israel  Manilla  Aguirre", TipoDePersonal="Confianza", NombreDelCargo="Departamento de Certificaci�n", NombreDelCargoSuperior="Subdirecci�n de Certificaci�n", UnidadAdministrativa="DIRECCI�N GENERAL DE AUTORREGULACI�N", ClaveDelPuesto="OC1", NombreDelPuesto="JEFE DE DEPARTAMENTO", CorreoElectr�nico="adrian.manilla@ifai.org.mx" },
//            }.ForEach(i => context.ServidorPublicoIFAI.Add(i));

//            new List<Viaje>
//            {
//                new Viaje {MEC_ORIGEN="Requerimiento de UR", INST_GENERA="DIRECCIÓN GENERAL DE CAPACITACIÓN; PROMOCIÓN Y RELACIONES INSTITUCIONALES", UR="No disponible", TIPO_REP="Técnico", CONSECUTIVO="2013.N.0006", NOMBRE="MARIO ERNESTO MEJIA PACHON", CARGO="SUBDIRECTOR DE OTROS SUJETOS OBLIGADOS,NC3,Nacional,No disponible,IFAI/SG/DGCPRI/045/2013,México,Distrito Federal,Ciudad de México,México,Baja California,Tijuana,1250,MXP,VINCLACION CON ESTADOS Y MUNICIPIOS,Participación en evento público,REUNION DE LA REGION NORTE DE LA COMAIP; REUNION DE LA COMISION DE GESTION DOCUMENTAL; TECNOLOGIAS DE LA INFORMACION Y GOBIERNO ABIERTO DE LA COMAIP Y EN EL PRIMER FORO NACIONAL DE ANALISIS Y REFLEXION SOBRE LA REFORMA CONSTITUCIONAL EN MATERIA DE TRANSPARENCIA Y ACCESO A LA INFORMACION PUBLICA EN MEXICO,No disponible,1/31/2013,02/02/2013,PARTICIPAR EN LA REUNION DE LA REGION NORTE DE LA CONFERENCIA MEXICANA PARA EL ACCESO A LA INFORMACION PUBLICA (COMAIP); REUNION DE LA COMISION DE GESTION DOCUMENTAL; TECNOLOGIAS DE LA INFORMACION Y GOBIERNO ABIERTO DE LA CONFERENCIA MEXICANA PARA EL ACCESO A LA INFORMACION PUBLICA (COMAIP) Y EN EL PRIMER FORO NACIONAL DE ANALISIS Y REFLEXION SOBRE LA REFORMA CONSTITUCIONAL EN MATERIA DE TRANSPARENCIA Y ACCESO A LA INFORMACION PUBLICA EN MEXICO; ORGANIZADO POR LA CONFERENCIA MEXICANA PARA EL ACCESO A LA INFORMACION PUBLICA (COMAIP).,No disponible,Se participo en la Reunión de la Región Norte de la COMAIP; Reunión de la Gestión Documental; Tecnologías de la Información y Gobierno Abierto de la COMAIP,Se renovaron los coordinadores de la Región Norte de la COMAIP,Se cumplió con las atribuciones del IFAI.,No disponible,IFAI,Aéreo,Aeroméxico,AM 170,Aeroméxico,AM 177,1/31/2013,02/02/2013,6444,2500,IFAI,Grand Hotel Tijuana,1/31/2013,02/02/2013,2040,2500,No disponible,No disponible,No aplica
//" }
//            }.ForEach(i => context.Viajes.Add(i));
        }
    }
}
