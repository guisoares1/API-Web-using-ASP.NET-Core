using System;

namespace ContosoPizza.models
{
public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsGlutenFree { get; set; }
        public DateTime DataDesativacao { get; set; }
        public bool Desatvado { get; set;}
    public void Desativar(){
         DataDesativacao = DateTime.Now;
         Desatvado = true;
    }
}
}