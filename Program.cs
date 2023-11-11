// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static string digito11(string claveAcceso48)
        {
            if(claveAcceso48.Length > 48)
            {
                System.Console.WriteLine($"La longitud de la clave de acceso {claveAcceso48} es mayor a 48");
                return "";
            }
            var clave1 = claveAcceso48.ToCharArray();
            int suma = 0, factor = 7;

            foreach (var item in clave1)
            {

                suma = suma + Convert.ToInt32(item.ToString()) * factor;
                factor = factor - 1;
                if (factor == 1)
                    factor = 7;

            }
            var digitoverificador = (suma % 11);
            digitoverificador = 11 - digitoverificador;
            if (digitoverificador == 11)
                digitoverificador = 0;
            else if (digitoverificador == 10)
                digitoverificador = 1;

            
            return "Clave de Acceso SRI: " + claveAcceso48 + digitoverificador.ToString(); ;


}

System.Console.WriteLine( digito11("061120230709928236820012012012000002695123456781")) ;