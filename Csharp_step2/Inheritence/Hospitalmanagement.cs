using System;
interface Idoctor
{
    void services();
    void appointment(string patientname, string doctorname, DateTime time);
    void prescription(int patientid, string medicine);
    void billing(double amount, string medicine);



}
class Treatment : Idoctor
{
    // patient name,doctor name ,time
    public void appointment(string patientname, string doctorname, DateTime time)
    {

        Console.WriteLine("Appointment details");
        Console.WriteLine($"Patient Name:{patientname},Doctor Name:{doctorname},Date and Time:{time}");
    }

    public void billing(double amount, string medicine)
    {
        if (medicine == null)
        {
            Console.WriteLine("Out of stock");
        }
        Console.WriteLine($"Total bill is:{amount}");
    }

    public void prescription(int patientid, string medicine)
    {
        Console.WriteLine($"Patient id is:{patientid} and medcine prescribed:{medicine}");

    }

    public void services()
    {
        Console.WriteLine("We are open 24/7");
    }
}
public class Hospital

{

    public static string HospitalName = "srikara hospitals";

    public static string location = "madinaguda";

    //static method

    public static void displayHospitalInfo()

    {

        Console.WriteLine($"This is Hospital Application");

        Console.WriteLine($"welcome to {HospitalName} and located in {location}");

    }

}

////doctor class with non-static members

public class Doctor

{

    public string Name { get; set; }

    public string Specialization { get; set; }

    public Doctor(string name, string specialization)

    {

        Name = name;

        Specialization = specialization;

    }

    public void DisplayDoctorInfo()

    {

        Console.WriteLine($"Doctor: Dr. {Name}, Specialization: {Specialization}");

    }

}

//patient class with non static members

public class Patient

{

    public string Name { get; set; }

    public string Treatment { get; set; }

    //constructor

    public Patient(string name, string treatment)

    {

        Name = name;

        Treatment = treatment;

    }

    public void DisplayPatientInfo()

    {

        Console.WriteLine($"Patient: {Name}, treatment: {Treatment}");

    }

}


class hospitalAPP

{

    public static void Main()

    {

        Hospital.displayHospitalInfo();

        //Create doctor and patient instances
        Console.WriteLine("---------------------------------");
        Doctor doctor = new Doctor("sushma", "pediatrician");

        Console.WriteLine("----------------------------");
        Patient patient = new Patient("Devansh", "fever");

        Console.WriteLine("\n--- Consultation Details ---");

        doctor.DisplayDoctorInfo();

        patient.DisplayPatientInfo();
        Console.WriteLine("------------------------------");
        Idoctor idoctor = new Treatment();
        idoctor.prescription(23, "Paracetemol");
        idoctor.billing(400, "paracetemol");
        idoctor.appointment("Usha", "Narmada", DateTime.Today);
        idoctor.services();
    }

}