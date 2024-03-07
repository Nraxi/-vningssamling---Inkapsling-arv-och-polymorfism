using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    //Polymorfism
    public abstract class UserError
    {
        public abstract string UEMessage();
        
    }
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    public class TextInputError : UserError 
    {
        public override string UEMessage() 
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    public class Jedi : UserError
    {
        public override string UEMessage()
        {
            return "You cant put a jedi in here";
        }
    }
    public class Mandalorians : UserError
    {
        public override string UEMessage()
        {
            return "There are no missions ready for you Mando";
        }
    }

    public class BountyHunter : UserError
    {
        public override string UEMessage()
        {
            return "You are No Mandalorian";
        }
    }
}

