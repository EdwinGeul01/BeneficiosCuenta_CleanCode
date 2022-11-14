
/* 
 * Temas a Evaluar:
Razones comunes para crear una función ✅--1
Razones para evitar la duplicidad ✅ -- 1
Sangría excesiva, forma flecha ✅ --2 
Transmitir la intención en funciones ✅ -- 1
Las funciones deben hacer una sola cosa, ejemplifique las ventajas ✅-- 3
Variables efímeras ✅ --3
Excesos de parámetros -- 3
Funciones demasiadas largas -- 1
Uso de excepciones como el try-catch --4 
*/



/*
 * Proyecto simulando los diferentes casos en donde una cuenta  ( en este caso universitaria ) podria abogar
 * por algun tipo de beneficio ofrecido por la universidad
 * 
*/


using System.Runtime.Serialization;

class alumno
{
    
    public string nombre;
    public int numeroDeCuenta;
    public int edad;
    public int AñoDeInscripcion;
    public float indiceColegio;
    public float indiceUniversitario;
    public estado EstadoCuenta;
    public enum estado { activo , inactivo , reingreso}


    public alumno(string nombre, int numeroDeCuenta, int edad, int añoDeInscripcion, float indiceColegio, float indiceUniversitario, estado estadoCuenta)
    {
        this.nombre = nombre;
        this.numeroDeCuenta = numeroDeCuenta;
        this.edad = edad;
        AñoDeInscripcion = añoDeInscripcion;
        this.indiceColegio = indiceColegio;
        this.indiceUniversitario = indiceUniversitario;
        EstadoCuenta = estadoCuenta;
    }
}


class CalculosBeneficio
{
    alumno alumno = new alumno("Jose", 22222, 24, 2018, 94,90,alumno.estado.activo);
    


    public bool VerificarSiCalificaBeca(alumno alumno)
    {
        if (alumno.edad >= 23)
        {
            return false;
        }

        if (alumno.AñoDeInscripcion <= 2015)
        {
        return false;
        }

        if (alumno.indiceColegio <= 91)
        {
        return false;
        }
       
        
        return true;

    }

    public void CalcularAplicacionBeca()
    {

        if (alumno.EstadoCuenta == alumno.estado.activo)
        {
     
            if(VerificarSiCalificaBeca(alumno))
                {
                        Console.WriteLine("aplica ha beca");
                }

        }
        else if (alumno.EstadoCuenta == alumno.estado.reingreso)
        {
            if (alumno.indiceUniversitario > 91)
            {
                if (VerificarSiCalificaBeca(alumno))
                {
                    Console.WriteLine("aplica ha beca");
                }

            }
            else
            {
                Console.WriteLine("no aplica ha beca");
            }

        }

    }
     






    public void Calcular()
    {
        if(alumno.EstadoCuenta == alumno.estado.activo)
        {
            if(alumno.edad < 23)
            {
                if (alumno.AñoDeInscripcion > 2015)
                {
                    if(alumno.indiceColegio > 91)
                    {
                        Console.WriteLine("aplica ha beca");
                    }
                    else
                    {
                        Console.WriteLine("no aplica ha beca");
                    }
                }
                else
                {
                    Console.WriteLine("no aplica ha beca");
                }
            }
            else
            {
                Console.WriteLine("no aplica ha beca");
            }

        }
        else if (alumno.EstadoCuenta == alumno.estado.reingreso)
        {
            if(alumno.indiceUniversitario > 91)
            {
                if (alumno.edad < 23)
                {
                    if (alumno.AñoDeInscripcion > 2015)
                    {
                        if (alumno.indiceColegio > 91)
                        {
                            Console.WriteLine("aplica ha beca");
                        }
                        else
                        {
                            Console.WriteLine("no aplica ha beca");
                        }
                    }
                    else
                    {
                        Console.WriteLine("no aplica ha beca");
                    }
                }
                else
                {
                    Console.WriteLine("no aplica ha beca");
                }

            }
            else
            {
                Console.WriteLine("no aplica ha beca");
            }

       }




    }




}



class Calendar
{
    string GetDAy(int n)
    {
        string dia = "";
        if (n == 1)
        {
            dia = "lunes";
        }
        if (n == 2)
        {
            dia = "martes";
        }
        if (n == 3)
        {
            dia = "miercoles";
        }
        if (n == 4)
        {
            dia = "jueves";
        }
        if (n == 5)
        {
            dia = "viernes";
        }
        if (n == 6)
        {
            dia = "sabado";
        }
        if (n == 7)
        {
            dia = "domingo";
        }
        if (dia == "")
        {
            Console.WriteLine("Fuera del rango");
        }

        return dia;

    }

    string GetDAy_DRY(int n)
    {

        
        string[] days = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

        try
        {

            if (n < 1 || n > 7)
            {
                return ("Fuera del rango");

            }

            return days[n - 1];



        }
        catch (Exception e)
        {
            return e.Message;
        
        }
   


    }





}


class SistemaFacturacion
{



    public float calcularDescuento(float descuento,float precio)
    {
        return descuento * precio;
    }


    public float calcularImpuesto(float impuesto , float precio)
    {
        return impuesto * precio;
    }



    public float CalcularPrecioNeto(float precio)
    {
       float descuento = calcularDescuento(0.5f, precio);
       float impuesto = calcularImpuesto(0.15f, precio);

        return precio - descuento + impuesto;


    }


    public float CalcularTodo(float precio , int descuento , int TipoCliente , float impuesto)
    {
        float total = precio - (precio * descuento) + (precio * impuesto);

        return total;


    }


}

class MainClass
{
    public static void Main(string[] args)
    { 
        CalculosBeneficio calculosBeneficio = new CalculosBeneficio();
        calculosBeneficio.Calcular();


        SistemaFacturacion sistemaFacturacion = new SistemaFacturacion();
        Console.WriteLine("Precio neto = " +  sistemaFacturacion.CalcularPrecioNeto(2000));


    }


}