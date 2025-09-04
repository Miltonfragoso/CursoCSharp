using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCodeEquals.Entities
{
    public  class Cliente
    {
        public string Nome{ get; set; }
        public string Email{ get; set; }



        //Por ser uma classe personalizada, precisamos sobrepor os metodos Equals e GetHashCode
        override public bool Equals(object obj)
        {
            if (!(obj is Cliente))
            {
                return false;
            }
            Cliente outro = obj as Cliente;
            return Email.Equals(outro.Email);
        }

        override public int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
