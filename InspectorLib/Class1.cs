using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string mainInspector = "Васильев Василий Иванович";
        private List<string> workers = new List<string> { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };

        public string GetInspector()
        {
            return mainInspector;
        }

        public string GetCarInspection()
        {
            return "Автоинспекция г. Чита";
        }

        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                mainInspector = fullname;
                return true;
            }
            return false;
        }

        public string GenerateNumber(int number, char symbol, int code)
        {
            return $"{char.ToUpper(symbol)}{number:D4}_{code:D2}";
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
