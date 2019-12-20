using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandomas
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double rez;
            char simbolis;
            cout << "Iveskite skaicius" << endl;
            cin >> a >> b;
            cout << "Iveskite simboli" << endl;
            cin >> simbolis;

            if (simbolis == '+')
            {
                rez = a + b;
            }
            else if (simbolis == '-')
            {
                rez = a - b;
            }
            else if (simbolis == '*')
            {
                rez = a * b;
            }
            else if (simbolis == '/')
            {
                if (b != 0)
                {
                    rez = a / b;
                }
                else
                {
                    rez = a;
                }
            }

            if (simbolis == '/' && b == 0)
            {
                cout << "Klaida, dalyba is nulio negalima!" << endl;
            }
            else
            {
                cout << "Rezult: " << rez << endl;
            }
            system("pause");
            return 0;
        }
    }
}
