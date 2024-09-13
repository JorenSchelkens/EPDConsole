namespace Chipsoft.Assignments.EPDApplication.Exceptions;

public class AppointmentOverlapException(string fullName)
    : Exception($"Deze afspraak overlapt met een andere afspraak voor {fullName}");
