// Usa declaraciones `if` para verificar condiciones y cambiar el flujo del programa en base a diferentes valores de variables.

namespace CSharpPractices
{
    public static class  Ejercicio3_CondicionesYDecisiones
    {
        public static void PracticaIf()
        {
            bool isAuthenticated = true;
            bool isAdmin = false;
            
            if (isAuthenticated && isAdmin)
            {
                Console.WriteLine("Acceso permitido, usted es un administrador");
            } else if (isAuthenticated && !isAdmin)
            {
                Console.WriteLine("Acceso denegado, pero usted es un usuario normal");
            } else
            {
                Console.WriteLine("Acceso denegado");
            }
        }
    }
}

