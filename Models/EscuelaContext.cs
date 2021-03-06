using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NetCore_Estudio.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.AñoDeCreación = 2020;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Horizonte del sol";
            escuela.Direccion = "Cll 81 - 20";
            escuela.Pais = "Peru";
            escuela.Ciudad = "Lima";
            escuela.TipoEscuela = TiposEscuela.Primaria;

            // Cargar cursos escuela
            var cursos = CargarCursos(escuela);

            // Por cada curso carga asignaturas
            var asignaturas = CargarAsignaturas(cursos);

            // Cargar alumnos
            var alumnos = CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
            // Carga de Evaluaciones

           /*  modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura
                {
                    Nombre = "Matematicas",
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura
                {
                    Nombre = "Ciencias",
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura
                {
                    Nombre = "Español",
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura
                {
                    Nombre = "Ingles",
                    Id = Guid.NewGuid().ToString()
                }
            );
            modelBuilder.Entity<Alumno>()
                        .HasData(GenerarAlumnosAlAzar().ToArray()); */
        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();
            Random rnd = new Random();
            foreach (var curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }
         

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                var tmpList = new List<Asignatura>
                {
                    new Asignatura
                {
                    Nombre = "Matematicas",
                    CursoId = curso.Id,
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura
                {
                    Nombre = "Ciencias",
                    CursoId = curso.Id,
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura
                {
                    Nombre = "Español",
                    CursoId = curso.Id,
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura
                {
                    Nombre = "Ingles",
                    CursoId = curso.Id,
                    Id = Guid.NewGuid().ToString()
                }

                };
                listaCompleta.AddRange(tmpList);
                // curso.Asignaturas = tmpList;
            }
            return listaCompleta;
        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>()
            {
                new Curso () {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = escuela.Id,
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana
                },
                new Curso () {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = escuela.Id,
                    Nombre = "102",
                    Jornada = TiposJornada.Mañana
                },
                new Curso () {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = escuela.Id,
                    Nombre = "103",
                    Jornada = TiposJornada.Mañana
                },
                new Curso () {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = escuela.Id,
                    Nombre = "104",
                    Jornada = TiposJornada.Tarde
                },
                new Curso () {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = escuela.Id,
                    Nombre = "105",
                    Jornada = TiposJornada.Tarde
                }
            };
        }

        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   CursoId = curso.Id,
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString()
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }
}