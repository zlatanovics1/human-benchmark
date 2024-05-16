using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Scores
{
    int typer => 0;
    int shooting => 0;

}

namespace WinFormsAppGameVerse
{
    internal class User
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string role {  get; set; }
        public Scores scores { get; set; }

    }
}
