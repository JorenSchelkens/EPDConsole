namespace Chipsoft.Assignments.EPDApplication.Exceptions;

public class DatabaseException(string origin) : Exception($"Er is iets fout gegaan in de databank door: {origin}");
