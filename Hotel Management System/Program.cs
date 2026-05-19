using System.Data;

namespace Hotel_Management_System
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //////////////////// Register New guest  Storage //////////////////////


            // guest info
            string guestName = "";
            string roomType = "";
            string checkInDate = "";
            string checkOutDate = "";
            string roomNotes = "";

            //guest number 
            int guestPhone = 0;
            double nightlyRate = 0.0;
            int roomNumber = 0;
            int loyaltyPoints = 0;
            int numberOfNights = 0;
            int discountPercentage = 0;



            //bool flags
            bool isGuestRegistered = false;
            bool isGuestChekedIn = false;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("==Registeration==");

                Console.WriteLine("0. Register new guest ");
                Console.WriteLine("1.View guest information ");
                Console.WriteLine("2.Check-In guest");
                Console.WriteLine("3.Check-Out & Bill");
                Console.WriteLine("4. Apply Discount");
                Console.WriteLine("5.Upgrade Room");
                Console.WriteLine("6.Add Room Service Not");
                Console.WriteLine("7. Search Guest by Name");
                Console.WriteLine("8. Calculate Loyalty Points");
                Console.WriteLine("9. Print Receipt ");
                Console.WriteLine("10. Edit Guest Name ");
                Console.WriteLine("11. Exit");

                Console.WriteLine("please choice an option");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine(" Register New Guest");
                        break;
                    case 1:
                        Console.WriteLine("View Guest Information");
                        Console.WriteLine("=======================");

                        // chack if there is guest registred or not
                        if (isGuestRegistered == false)
                        {
                            Console.WriteLine("No Guest Registered!");
                            break;
                        }

                        // View guest info
                        Console.WriteLine("Guest Name: " + guestName.ToUpper());
                        Console.WriteLine("Guest Phone: " + guestPhone);
                        Console.WriteLine(" Room Number: " + Convert.ToString(roomNumber));
                        Console.WriteLine(" Room Type: " + roomType);
                        Console.WriteLine(" Nihgtly Rste: " + Math.Round(nightlyRate, 2));

                        break;





                    // check if guest checkedin
                    case 2:
                        Console.WriteLine("Check-In Guest");


                        if (isGuestChekedIn == false)
                        {
                            Console.WriteLine("No Guest Registered!");

                            break;
                        }
                        if (isGuestChekedIn == true)
                        {
                            Console.WriteLine(" CkekedIn Done ");
                            break;
                        }

                        //// Number of nights////

                        Console.Write("Enter Number of Nights");
                        numberOfNights = int.Parse(Console.ReadLine());

                        ////Date Time////

                        checkInDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm");///Time and date to check in

                        DateTime checkOut = DateTime.Today.AddDays(numberOfNights);///Number of Nights

                        checkOutDate = DateTime.Now.ToString("yyyy-mm-dd");///Check out date


                        //// change states ////

                        isGuestChekedIn = true;
                        Console.WriteLine("Checked in successfully! ");
                        Console.WriteLine(" Check-in" + checkInDate);
                        Console.WriteLine("Check-Out" + checkOutDate);

                        break;






                    //////////// Check-Out & Bill //////////

                    case 3: //calculate the bill
                        if (isGuestChekedIn == false)
                            Console.WriteLine("Faild to check-In!!");
                        break;



                        double total = numberOfNights * nightlyRate;
                        double discount = total * (discountPercentage / 100.0);
                        double fainalBill = Math.Round(total - discount, 2);

                        ///Show the bill

                        Console.WriteLine("Total" + total);
                        Console.WriteLine("Discount" + discount);
                        Console.WriteLine("Fainal Amount" + fainalBill);


                        ///Reset

                        isGuestChekedIn = false;
                        isGuestRegistered = false;
                        guestName = "";
                        guestPhone = 0;
                        roomNumber = 0;
                        roomType = "";
                        nightlyRate = 0.0;
                        numberOfNights = 0;
                        discountPercentage = 0;
                        checkInDate = "";
                        checkOutDate = "";
                        roomNotes = "";

                        break;





                    ///Case4 Apply Discount 

                    case 4:
                        {
                            if (isGuestRegistered == false)

                                Console.WriteLine("Still not registered");
                            break;
                        }
                        Console.WriteLine("Apply percentage discount:");
                        discountPercentage = double.Parse(Console.ReadLine();
                        discountPercentage = Math.Abs(discountPercentage);

                        ///Calculate the precentage

                        double Orginal = numberOfNights * discountPercentage;
                        double Saved = Math.Round(Orginal * (numberOfNights / 100.0), 2);

                        double NewToltal = Orginal - Saved;


                        ///Show 

                        Console.WriteLine("Original amount" + Orginal);
                        Console.WriteLine("Seved amount" + Saved);
                        Console.WriteLine("New total " + NewToltal);

                        break;
                
                    /// case 5 
                    case 5:
                        Console.WriteLine("Upgrade Room");

                        if (isGuestRegistered == false)
                        {
                            Console.WriteLine("No guest registerd ");
                            break;
                        }

                        Console.WriteLine ("");











                }












            }


                








            }





        }
                    










                }
        

    


