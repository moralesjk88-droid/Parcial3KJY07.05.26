// See https://aka.ms/new-console-template for more information
using System.IO;
class Registro

{
    private string nombreMascota;
    private int edad;
    private double peso;
    private int temperatura;
    private DateTime fechaNacimiento;

    public string NombreMascota
    {
        get { return nombreMascota; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                nombreMascota = value;
            }
            else
            {
                Console.WriteLine("Nombre no valido");

            }
        }

    }

    public int Edad
    {
        get { return edad; }
        set
        {
            if (value < 0 && value > 100)
            {
                edad = value;
            }
            else
          
                Console.WriteLine("Edad no valida");
            }
        }

    public double Peso
        { get { return peso; }
        set { if (value<0)
            { peso = value; }
            else
            {
                Console.WriteLine("Peso no valido");
            }
        } }

    public int Temperatura
    {
        get { return temperatura; }
        set {
            if (value >= 10 && value < 32)
            {
                Console.WriteLine("Temperatura estable");
                temperatura = value;
            }

            else { Console.WriteLine("Advertencia: Temperatura elevada detectada"); } }
        }


    public DateTime FechaNacimeinto
    {
        get { return fechaNacimiento; }
        set
        {
            if (fechaNacimiento < DateTime.Now)
            {
                fechaNacimiento = value;
            }
            else
            {
                Console.WriteLine("Edad no valida");
            }
        }
    }

    public Registro(string nombreMascota, int edad, double peso,int temperatura, DateTime fechaNacimiento)
    {
        NombreMascota=nombreMascota;
        Edad=edad;
        Peso=peso;
        Temperatura=temperatura;
        FechaNacimeinto = fechaNacimiento;
    }

    public virtual void MostrarDatos()
    {
        Console.WriteLine("Nombre del paciente: " + NombreMascota);
        Console.WriteLine("Edad: "+Edad);
        Console.WriteLine("Peso: "+Peso);
        Console.WriteLine("Fecha de Nacimiento: "+FechaNacimeinto);
    }

    public virtual string GuardarDatos()
    {
        return
            "Nombre del paciente: " + NombreMascota + Environment.NewLine +
            "Edad: " + Edad + Environment.NewLine +
            "Peso: " + Peso + Environment.NewLine +
            "Fecha de nacimiento: "+FechaNacimeinto+Environment.NewLine;

    }
     
 public void DatosArchivo(string ruta)
    {
        File.AppendAllText(ruta,GuardarDatos());

    }

}

class Dueño:Registro
{
    private string nombreDueño;
    private string numeroTelefono;

    public string NombreDueño
    {
        get { return nombreDueño; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                nombreDueño = value;
            }
            else
            {
                Console.WriteLine("Nombre no valido");
            }
        }
    }

    public string NumeroTelefono
    {
        get { return numeroTelefono; }
        set{
            if (value.Length==8 && long.TryParse(value, out _))
            {
                numeroTelefono = value;
            }
            else
            {
                Console.WriteLine("Número de telefono no valido");
            }
        }
    }

    public Dueño(string nombreMascota, int edad, double peso, int temperatura, DateTime fechaNacimiento, string nombreDueño, string numeroTelefono)
        : base(nombreMascota, edad, peso, temperatura, fechaNacimiento)
      
 
    {
        NombreDueño = nombreDueño;
        NumeroTelefono= numeroTelefono;
    }

    public override string GuardarDatos()
    {
        return "Nombre del Dueño: "+NombreDueño+Environment.NewLine+
            "Número de telefono "+ numeroTelefono+Environment.NewLine ;
    }
    public  override void MostrarDatos()

    {
        base.MostrarDatos();
        Console.WriteLine("Datos del dueño: " + NombreDueño);
        Console.WriteLine("Número de telefono: " + NumeroTelefono);
    }



        

}
class Perro: Registro
{
    private string tamaño;
    private string raza;

    public string Tamaño
    {
        get { return tamaño;}   
       set
        {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    tamaño=value;
                }
                else
                {
                    Console.WriteLine("Tamaño no valido");
                }
            }
        }

    public string Raza
    {
        get { return raza; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                raza = value;

            }
            else
            {
                Console.WriteLine("Raza no valida");
            }
        }
    }

        public Perro(string nombreMascota, int edad, double peso, int temperatura, DateTime fechaNacimiento, string tamaño, string raza)
        : base(nombreMascota, edad, peso, temperatura, fechaNacimiento)
    {
        Tamaño = tamaño;
        Raza = raza;
    }

    public override void MostrarDatos()
    {
        
        base.MostrarDatos();
        Console.WriteLine(" Tamaño: "+ Tamaño);
        Console.WriteLine("Raza: " + Raza);
    }


}
class Gato : Registro
{
    private string tamaño;
    private string raza;

    public string Tamaño
    {
        get { return tamaño; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                tamaño = value;
            }
            else
            {
                Console.WriteLine("Tamaño no valido");
            }
        }
    }

    public string Raza
    {
        get { return raza; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                raza = value;

            }
            else
            {
                Console.WriteLine("Raza no valida");
            }
        }
    }

    public Gato(string nombreMascota, int edad, double peso, int temperatura, DateTime fechaNacimiento, string tamaño, string raza)
    : base(nombreMascota, edad, peso, temperatura, fechaNacimiento)
    {
        Tamaño = tamaño;
        Raza = raza;
    }

    public override void MostrarDatos()
    {

        base.MostrarDatos();
        Console.WriteLine(" Tamaño: " + Tamaño);
        Console.WriteLine("Raza: " + Raza);
    }


}

class Program
{
     static void Main()
    {
        Dictionary<string,Registro> mascotas=new Dictionary<string,Registro>();
        int opcion;

        do
        {
            Console.WriteLine("1. Registro de mascota");
            Console.WriteLine("2. Mostrar registros");
            Console.WriteLine("3. Buscar mascota");
            Console.WriteLine("4. Guardar Información en archivo");
            Console.WriteLine("5. Salir");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("No es una opcion valida");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nSeleccione una opcion");
                    Console.WriteLine("1. Gato");
                    Console.WriteLine("2. Perro");
                    int tipo;
                    while (!int.TryParse(Console.ReadLine(), out tipo)|| (tipo<1|| tipo>2 ))
                    {
                        Console.WriteLine("Eleccion no valida");    
                    }

                    if (tipo==1)
                    {
                         Console.WriteLine("Ingrese código de expediente: ");
                        string codigo=Console.ReadLine();
                        while (true)
                        {
                            if (!string.IsNullOrWhiteSpace(codigo))
                            {
                                Console.WriteLine("El codigo no puede ir vacio ");
                            }
                            else if (mascotas.ContainsKey(codigo))
                            {
                                Console.WriteLine("El codigo no puede ser repetido");
                            }
                        }
                        Console.WriteLine("Ingrese nombre de mascota: ");
                        string nombreMascota=Console.ReadLine();
                        Console.WriteLine("Ingrese la edad: ");
                        int edad;
                        if (!int.TryParse(Console.ReadLine(), out edad))
                        {
                            Console.WriteLine("Edad no valida");
                            continue;
                        }
                        Console.WriteLine("Ingrese el peso:");
                        double peso;
                        if (!double.TryParse(Console.ReadLine(), out peso))
                        {
                            Console.WriteLine("Peso no valido");
                        }



                    }

                   
                    break;

                    case 2:
                    break;
                    case 3:
                    break;
                        case 4:
                    break;
                        case 5:
                    Console.WriteLine("Hasta pronto");
                    break;
                default:
                    Console.WriteLine(" opcion no valida");
                    break;



                    }



        }
        while (opcion!=5);


    }
}



   



