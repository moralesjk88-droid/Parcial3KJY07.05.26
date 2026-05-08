// See https://aka.ms/new-console-template for more information

class Registro

{
    private string nombreMascota;
    private int edad;
    private double peso;
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

    public Registro(string nombreMascota, int edad, double peso, DateTime fechaNacimiento)
    {
        NombreMascota=nombreMascota;
        Edad=edad;
        Peso=peso;
        FechaNacimeinto = fechaNacimiento;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre del paciente: " + NombreMascota);
        Console.WriteLine("Edad: "+Edad);
        Console.WriteLine("Peso: "+Peso);
        Console.WriteLine("Fecha de Nacimiento: "+FechaNacimeinto);
    }

    public string GuardarDatos()
    {
        return
            "Nombre del paciente: " + NombreMascota + Environment.NewLine +
            "Edad: " + Edad + Environment.NewLine +
            "Peso: " + Peso + Environment.NewLine +
            "Fecha de nacimiento: "+FechaNacimeinto+Environment.NewLine;

    }
     
   /* public string DatosArchivo(string ruta)
    {
        FileAccess=FileAccess.Read;

    }*/

}

class Dueño:Registro
{
    private string nombreDueño;
    private int numeroTelefono;

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

}

   



