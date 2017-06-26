namespace HackAtHome.Entities
{
    public enum Status
    {
        Error = 0,
        Success = 1,
        InvalidUserOrNotInEvent = 2,
        OutOfDate = 3,
        AllSuccess = 999
    }

    public class ResultInfo
    {
        public Status Status { get; set; }
        // El valor del Token expira después de 10 minutos del último acceso al servicio REST
        public string Token { get; set; }

        public string FullName{  get; set; }
    }
}