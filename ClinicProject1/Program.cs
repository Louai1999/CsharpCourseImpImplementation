using System.ComponentModel.Design;
using System.Security.Permissions;

namespace ClinicProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System Storage (Variables)
            // store patient information
            string patientName = "";
            string patientEmail = "";
            string patientPhone = "";
            int patientAge = 0;
            bool isAppointmentBooked = false;
            bool isPatientRegistred = false;


            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Clinic Managment System");
                Console.WriteLine("0.Add Patient Information");
                Console.WriteLine("1.View Patient Information");
                Console.WriteLine("2.Edit Patient Information");
                Console.WriteLine("3.Book Appointment");
                Console.WriteLine("4.Cancel Appointment");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Please Select An Option From Menu: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)

                {
                    case 0: //add patient Information
                        if (isPatientRegistred == true)

                        {
                            Console.WriteLine("Patient Information already exists please edit account information if you want to change it ");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Enter patient Name: ");
                            patientName = Console.ReadLine();

                            Console.WriteLine("enter new age:");
                            patientAge = int.Parse(Console.ReadLine());


                            Console.WriteLine("Enter Patient Phone:");
                            patientPhone = Console.ReadLine();

                            Console.WriteLine("Enter patient Email:");
                            patientEmail = Console.ReadLine();

                            isPatientRegistred = true;
                            Console.WriteLine("patient informatio added successfully.");


                        }
                        break;

                    case 1: //View patient information 
                        if (isPatientRegistred == false)
                        {
                            Console.WriteLine("No patient found . Please add patient .");
                            break;

                        }
                        else
                        {
                            Console.WriteLine("===Patient Information===");
                            Console.WriteLine("Name: " + patientName);
                            Console.WriteLine(" Age:" + patientAge);
                            Console.WriteLine(" Phone:" + patientPhone);
                            Console.WriteLine("Email :" + patientEmail);
                        }
                        break;

                    case 2: //Edit Patient information

                        if (isPatientRegistred == false)
                        {
                            Console.WriteLine("choose an option to edit:");
                            Console.WriteLine("1.Name");
                            Console.WriteLine("2. age");
                            Console.WriteLine("3. Phone");
                            Console.WriteLine("4. Email");
                            int choice = int.Parse(Console.ReadLine());

                            if (choice == 1)
                            {
                                Console.Write("Enter new name: ");
                                patientName = Console.ReadLine();
                                Console.WriteLine("Name updated successfully. ");
                            }
                            else if (choice == 2)
                            {
                                Console.WriteLine("Enter new age: ");
                                patientAge = int.Parse(Console.ReadLine());
                                Console.WriteLine("Age updated successfully.");
                            }

                            else if (choice == 3)
                            {
                                Console.WriteLine("Enter new phone: ");
                                patientPhone = Console.ReadLine();
                                Console.WriteLine("Phone updated successfully");
                            }

                            else if (choice == 4)
                            {
                                Console.WriteLine("Enter new email: ");
                                patientEmail = Console.ReadLine();
                                Console.WriteLine("Email ubdated successfully");

                            }
                            else
                            {
                                Console.WriteLine("Invalid option. please try again.");

                            }
                            break;

                        }
                        break;
                    case 3: // Book appointment

                        if (isPatientRegistred == false)
                        {
                            Console.WriteLine("No patient found. Please add patient information.");
                            break;
                        }
                        if (isAppointmentBooked == true)
                        {
                            Console.WriteLine("patient already has a booked appointment.");
                            break;
                        }



                        else

                        {
                            isAppointmentBooked = true;
                            Console.WriteLine("Appointment booked successfully for " + patientName + ".");
                        }
                        break;

                    case 4: //cancel appointment 
                        if (isAppointmentBooked == false)
                        {
                            Console.WriteLine("No appointment to cancel.");
                            break;

                        }

                        else
                        {
                            isAppointmentBooked = false;
                            Console.WriteLine("Appointment cancelled successfully.");
                        }
                        break;


                    case 5: //show patient status
                        if (isPatientRegistred == false)
                        {
                            Console.WriteLine("No user found.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(" Patient : " + patientName);
                            Console.WriteLine("Appointment status: " + (isAppointmentBooked));

                        }

                        break;

                    case 6: //Exit
                        exit = true; break;

                    default: // invalid option
                        Console.WriteLine(" Invalid option please try again");
                        break;






                } //While end


                Console.WriteLine("Press any key to continue ");
                Console.ReadLine();
                Console.Clear();




                
                    
                

























            }
        }
    }
}