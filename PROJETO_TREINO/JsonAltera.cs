using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace PROJETO_TREINO
{
    class JsonAltera
    {
        public List<Trabalho> Desserializador(string caminho)
        {

            var file = File.ReadAllText(caminho);
            var objetos = JsonConvert.DeserializeObject<List<Trabalho>>(file);
            return objetos;

        }
        
        public void Serializador(List<Trabalho> trabalho, string trajetoAlvo)
        {
           
            try
            {
                StreamWriter file = new StreamWriter(trajetoAlvo);
                string armazenaJson = JsonConvert.SerializeObject(trabalho);
                file.Write(armazenaJson);
                file.Close();
            }

            catch (Exception x)
            {

                Console.WriteLine(x.Message);

            }
        }
    }
}
