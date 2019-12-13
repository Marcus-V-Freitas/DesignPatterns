using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Flyweight
{
    public class FactoryFlyweight
    {

        private Hashtable _characters = new Hashtable();

        public FactoryFlyweight()
        {
            _characters.Add("Soldado Pesado", new Default("Soldado Pesado",1000));
            _characters.Add("Soldado Leve", new Default("Sodado Leve", 500));
        }

        public Character GetCharacters(string key)
        {
            Character character;
            if (_characters.ContainsKey(key)) {
                character = (Character)_characters[key];
            }
            else
            {
                if (key.StartsWith("Soldado")) {
                    _characters.Add(key, new Default(key, 200));
                    character = (Character)_characters[key];
                }
                else
                {
                    _characters.Add(key, new Boss(key, 9000));
                    character = (Boss)_characters[key];
                }
               
            }
            return character;
        }
    }
}
