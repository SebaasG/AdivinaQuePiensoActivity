using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica28_04.models;

namespace practica28_04
{
    public class LinqQueries
    {
        List<Book> lstBooks = new List<Book>(); 
        public LinqQueries(){
        using(StreamReader reader = new StreamReader("books.json")){
            string json = reader.ReadToEnd();
            this.lstBooks = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json,new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true}) ?? new List<Book>();
        }
    }
    }
}