using Microsoft.AspNetCore.Mvc;

namespace PresentacionWeb.Controlador
{
    public class LoginAcceso : Controller
    {
        public IActionResult Index(string username, string password)
        {
            if (IsValidUser(username, password)) // Implementa tu lógica de validación  
            {
                // Redirigir a la pestaña que deseas (categoría)  
                return RedirectToAction("Index", "Categoria"); // Asegúrate de tener el controlador y la acción correctos  
            }

            // Si falla, regresar al formulario con un mensaje de error.  
            ModelState.AddModelError("", "Credenciales inválidas");
            return View();
        }
        private bool IsValidUser(string username, string password)
        {
            // Implementa tu lógica de validación aquí  
            return true; // Solo para propósitos de prueba, cámbialo a tu lógica real  
        }
    }
}
