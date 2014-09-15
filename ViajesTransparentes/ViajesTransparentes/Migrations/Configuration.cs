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
//                new ServidorPublicoIFAI { Institucion="INSTITUTO FEDERAL DE ACCESO A LA INFORMACI覰 Y PROTECCI覰 DE DATOS ORGANISMO AUT覰OMO en proceso de reestructuraci髇", Nombre="Liliana", PrimerApellido="Herrera", SegundoApellido="Mart韓", NombreCompleto="Liliana Herrera Mart韓", TipoDePersonal="Confianza", NombreDelCargo="Secretar韆 Particular", NombreDelCargoSuperior="Comisionado", UnidadAdministrativa="Comisionado", ClaveDelPuesto="MC03", NombreDelPuesto="SECRETARIO PARTICULAR DE PONENCIA", CorreoElectr髇ico="liliana.herrera@ifai.org.mx" },
//                new ServidorPublicoIFAI { Institucion="INSTITUTO FEDERAL DE ACCESO A LA INFORMACI覰 Y PROTECCI覰 DE DATOS ORGANISMO AUT覰OMO en proceso de reestructuraci髇", Nombre="Adri醤 Israel", PrimerApellido="Manilla", SegundoApellido="Aguirre", NombreCompleto="Adri醤 Israel  Manilla  Aguirre", TipoDePersonal="Confianza", NombreDelCargo="Departamento de Certificaci髇", NombreDelCargoSuperior="Subdirecci髇 de Certificaci髇", UnidadAdministrativa="DIRECCI覰 GENERAL DE AUTORREGULACI覰", ClaveDelPuesto="OC1", NombreDelPuesto="JEFE DE DEPARTAMENTO", CorreoElectr髇ico="adrian.manilla@ifai.org.mx" },
//            }.ForEach(i => context.ServidorPublicoIFAI.Add(i));

//            new List<Viaje>
//            {
//                new Viaje {MEC_ORIGEN="Requerimiento de UR", INST_GENERA="DIRECCI脫N GENERAL DE CAPACITACI脫N; PROMOCI脫N Y RELACIONES INSTITUCIONALES", UR="No disponible", TIPO_REP="T茅cnico", CONSECUTIVO="2013.N.0006", NOMBRE="MARIO ERNESTO MEJIA PACHON", CARGO="SUBDIRECTOR DE OTROS SUJETOS OBLIGADOS,NC3,Nacional,No disponible,IFAI/SG/DGCPRI/045/2013,M茅xico,Distrito Federal,Ciudad de M茅xico,M茅xico,Baja California,Tijuana,1250,MXP,VINCLACION CON ESTADOS Y MUNICIPIOS,Participaci贸n en evento p煤blico,REUNION DE LA REGION NORTE DE LA COMAIP; REUNION DE LA COMISION DE GESTION DOCUMENTAL; TECNOLOGIAS DE LA INFORMACION Y GOBIERNO ABIERTO DE LA COMAIP Y EN EL PRIMER FORO NACIONAL DE ANALISIS Y REFLEXION SOBRE LA REFORMA CONSTITUCIONAL EN MATERIA DE TRANSPARENCIA Y ACCESO A LA INFORMACION PUBLICA EN MEXICO,No disponible,1/31/2013,02/02/2013,PARTICIPAR EN LA REUNION DE LA REGION NORTE DE LA CONFERENCIA MEXICANA PARA EL ACCESO A LA INFORMACION PUBLICA (COMAIP); REUNION DE LA COMISION DE GESTION DOCUMENTAL; TECNOLOGIAS DE LA INFORMACION Y GOBIERNO ABIERTO DE LA CONFERENCIA MEXICANA PARA EL ACCESO A LA INFORMACION PUBLICA (COMAIP) Y EN EL PRIMER FORO NACIONAL DE ANALISIS Y REFLEXION SOBRE LA REFORMA CONSTITUCIONAL EN MATERIA DE TRANSPARENCIA Y ACCESO A LA INFORMACION PUBLICA EN MEXICO; ORGANIZADO POR LA CONFERENCIA MEXICANA PARA EL ACCESO A LA INFORMACION PUBLICA (COMAIP).,No disponible,Se participo en la Reuni贸n de la Regi贸n Norte de la COMAIP; Reuni贸n de la Gesti贸n Documental; Tecnolog铆as de la Informaci贸n y Gobierno Abierto de la COMAIP,Se renovaron los coordinadores de la Regi贸n Norte de la COMAIP,Se cumpli贸 con las atribuciones del IFAI.,No disponible,IFAI,A茅reo,Aerom茅xico,AM 170,Aerom茅xico,AM 177,1/31/2013,02/02/2013,6444,2500,IFAI,Grand Hotel Tijuana,1/31/2013,02/02/2013,2040,2500,No disponible,No disponible,No aplica
//" }
//            }.ForEach(i => context.Viajes.Add(i));
        }
    }
}
