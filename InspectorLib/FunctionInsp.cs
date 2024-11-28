using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string inspectorName = "Васильев Василий Иванович";
        private List<string> workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        public string GetInspector()
        {
            return inspectorName;
        }

        public string GetCarInspection()
        {
            return "Автоинспекция г. Чита";
        }

        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                inspectorName = fullname;
                return true;
            }
            return false;
        }
        public string GenerateNumber()
        {
            Random rand = new Random(); int number = rand.Next(1000, 9000);
            // Генерация случайного числа от 100 до 999
            string symbols = "АВЕКМНОРСТУХ";
            // Доступные символы кириллицы
            char firstSymbol = symbols[rand.Next(symbols.Length)];
            return $"{firstSymbol}{number}_75";
        }

        public List<string> GetWorker()
        {
            return workers;
        }

        public void AddWorker(string fullname)
        {
            if (!workers.Contains(fullname))
            {
                workers.Add(fullname);
            }
        }
    }
}

