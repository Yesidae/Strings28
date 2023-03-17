using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Strings.Logic
{
    public class String28
    {
        private readonly string _viga;

        public String28(string text)
        {
            _viga = text;
        }
        
        public bool Viga()
        {
            string n = _viga;
            int conexiones = 0;
            int sumaconexion = 0;
            int viga = 0;

            // Asignement beam value
            if (_viga[0] == '%')
            {
                viga = 10;
            }

            if (_viga[0] == '&')
            {
                viga = 30;
            }

            if (_viga[0] == '#')
            {
                viga = 90;
            }


            // Beam validations
            if (_viga[0] == '%' || _viga[0] == '&' || _viga[0] == '#') 
            {
                for (int i = 1; i < n.Length; i++)
                {

                    if (n[i] == '=' || n[i] == '*')
                    {
                        if (n[i] == '=')
                        {
                            conexiones = 0;
                            sumaconexion += 1;
                        }

                        if (n[i] == '*')
                        {
                            conexiones++;
                            sumaconexion += sumaconexion * 2;

                        }

                        if (sumaconexion > viga || conexiones == 2)
                        {
                            return false;
                        } 
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                // throw new ArgumentException("poorly constructed beam");
                return false;
            }
            return true;
        }
    }
}