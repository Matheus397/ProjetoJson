using System.Collections.Generic;

namespace PROJETO_TREINO
{
    class friends
    {
        public string id_friend { get; set; }
        public string nome_friend { get; set; }
    }

    class Email
    {
        public string EnviarPorEmail { get; set; }
        public string EnderecoEmail { get; set; }
    }

    class SMS
    {
        public string Celular { get; set; }
    }
    class EmissorDigital
    {
        public SMS SMS { get; set; }
        public Email Email { get; set; }
    }
    class Trabalho
    {     
            public string _id { get; set; }
            public string index { get; set; }
            public string Guid { get; set; }
            public string IsActive { get; set; }
            public string Balance { get; set; }
            public string Picture { get; set; }
            public string Age { get; set; }
            public string EyeColor { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Company { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string About { get; set; }
            public string Registered { get; set; }
            public string Latitude { get; set; }
            public string Longitude { get; set; }
            public List<string> Tags { get; set; } = new List<string>();
            public List<friends> Friends { get; set; } = new List<friends>();
            public string Greeting { get; set; }
            public string FavoriteFruit { get; set; }
            public EmissorDigital EmissaoDigital { get; set; }

            public override string ToString()
            {
                return $"Nome: {Name} Genero: {Company} Index: {index}";
            }
    }

    
         
}
        
    

