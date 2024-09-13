namespace Chipsoft.Assignments.EPDConsole
{
    public class Program
    {
        //Don't create EF migrations, use the reset db option
        //This deletes and recreates the db, this makes sure all tables exist

        private static readonly EPDDbContext DbContext = new();

        private static readonly IPatientService PatientService = new PatientService(DbContext);
        private static readonly IPhysicianService PhysicianService = new PhysicianService(DbContext);
        private static readonly IAppointmentService AppointmentService = new AppointmentService(DbContext);

        private static readonly IPrintService PrintService = new PrintService();
        private static readonly IInputService InputService = new InputService(PrintService);

        private static void AddPatient()
        {
            try
            {
                var patient = InputService.ReadPatientDTO();
                PatientService.Add(patient);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            InputHelper.WaitToContinue();
        }

        private static void ShowAppointment()
        {
            try
            {
                var appointments = AppointmentService.GetAll();
                PrintService.PrintAppointments(appointments);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            InputHelper.WaitToContinue();
        }

        private static void AddAppointment()
        {
            try
            {
                var patients = PatientService.GetAll();
                var physicians = PhysicianService.GetAll();

                var appointment = InputService.ReadAppointmentDTO(patients, physicians);
                AppointmentService.Add(appointment);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            InputHelper.WaitToContinue();
        }

        private static void DeletePhysician()
        {
            try
            {
                var physicians = PhysicianService.GetAll();
                PrintService.PrintPhysicians(physicians);

                var physicianId = InputHelper.ReadInt("Arts Id");
                PhysicianService.Delete(physicianId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            InputHelper.WaitToContinue();
        }

        private static void AddPhysician()
        {
            try
            {
                var physician = InputService.ReadPhysicianDTO();
                PhysicianService.Add(physician);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            InputHelper.WaitToContinue();
        }

        private static void DeletePatient()
        {
            try
            {
                var patients = PatientService.GetAll();
                PrintService.PrintPatients(patients);

                var patientId = InputHelper.ReadInt("Patiënt Id");
                PatientService.Delete(patientId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            InputHelper.WaitToContinue();
        }


        #region FreeCodeForAssignment
        static void Main(string[] args)
        {
            while (ShowMenu())
            {
                //Continue
            }
        }

        public static bool ShowMenu()
        {
            Console.Clear();
            foreach (var line in File.ReadAllLines("logo.txt"))
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");
            Console.WriteLine("1 - Patient toevoegen");
            Console.WriteLine("2 - Patienten verwijderen");
            Console.WriteLine("3 - Arts toevoegen");
            Console.WriteLine("4 - Arts verwijderen");
            Console.WriteLine("5 - Afspraak toevoegen");
            Console.WriteLine("6 - Afspraken inzien");
            Console.WriteLine("7 - Sluiten");
            Console.WriteLine("8 - Reset db");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        AddPatient();
                        return true;
                    case 2:
                        DeletePatient();
                        return true;
                    case 3:
                        AddPhysician();
                        return true;
                    case 4:
                        DeletePhysician();
                        return true;
                    case 5:
                        AddAppointment();
                        return true;
                    case 6:
                        ShowAppointment();
                        return true;
                    case 7:
                        return false;
                    case 8:
                        DbContext.Database.EnsureDeleted();
                        DbContext.Database.EnsureCreated();
                        return true;
                    default:
                        return true;
                }
            }
            return true;
        }

        #endregion
    }
}