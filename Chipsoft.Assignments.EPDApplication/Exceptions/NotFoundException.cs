namespace Chipsoft.Assignments.EPDApplication.Exceptions;

public class NotFoundException(int id, string origin) : Exception($"De gevraagde entiteit met id: {id} is niet gevonden door: {origin}");
