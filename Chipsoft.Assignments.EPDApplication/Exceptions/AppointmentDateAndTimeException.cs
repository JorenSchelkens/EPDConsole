namespace Chipsoft.Assignments.EPDApplication.Exceptions;

public class AppointmentDateAndTimeException(DateTime dateAndTime)
    : Exception($"Afspraak kan niet op {dateAndTime.ToString("dd/MM/yyyy HH:mm")} gemaakt worden aangezien dit in het verleden is.");
