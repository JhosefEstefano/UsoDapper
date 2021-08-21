using Entities;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace UsoDapper
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<AreaEntity> ListaAreas = new List<AreaEntity>();

            Dapper dapper = new Dapper();

            ListaAreas = dapper.GetAll();

            foreach (var item in ListaAreas)
            {
                Console.WriteLine("Nombre Area:"+item.Nombre+" Codigo Area: "+ item.Codigo + " Creado por:" +item.CreadoPor);
                Console.WriteLine("////////////////////////////////////");
            }
        }
    }
}
