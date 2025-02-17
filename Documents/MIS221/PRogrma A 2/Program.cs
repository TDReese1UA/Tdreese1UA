string numChoice = "";

//Conversion Rates
const double USD_CURRENCY = 1;
const double YEN_CURRENCY = .0064;
const double YUAN_CURRENCY = .14;
const double POUND_CURRENCY = 1.22;
const double DOUBLOON_CURRENCY = 8.40;
const double DINAR_CURRENCY = .0074;

// string PostCurrency = GetPostCurrency();

while ( numChoice != "3"){ // Menu startup
    System.Console.WriteLine("Please Select your Option!\n 1. Convert Currency \n 2. Shipping Invoice \n 3. Exit");
    numChoice = Console.ReadLine();

    if ( numChoice == "1" ) //Start of Convert Currency Menu
{ 

        //Start of Initial Currency Code
//       

// Main

string initialCurrency = GetInitialCurrency();

string PostCurrency = GetPostCurrency();

double amount = GetAmount();

double convertedAmount = ConvertedCurrency(initialCurrency, PostCurrency, amount);

System.Console.WriteLine($"Your {amount} in {initialCurrency} will equal {convertedAmount} in {PostCurrency}!"); // EXTRA: Fancy Output

//End Main

static string GetInitialCurrency()
{
System.Console.WriteLine("Enter your initial currency type: (USD, Japanese Yen, Chinese Yuan, British Pound, Doubloons, Algerian Dinar)");
return Console.ReadLine().ToLower();
}

static string GetPostCurrency()
{
System.Console.WriteLine("Enter your desired end currency type: (USD, Japanese Yen, Chinese Yuan, British Pound, Doubloons, Algerian Dinar)");
return Console.ReadLine().ToLower();
}

double GetAmount(){
System.Console.WriteLine("Enter your amount!");
return double.Parse(Console.ReadLine());
}

static double ConvertedCurrency(string initialCurrency, string PostCurrency, double amount){
    double ICRate = GetRate(initialCurrency);
    double PCRate = GetRate(PostCurrency);

    return amount * (PCRate / ICRate);
}
// Extra!!! CONVERT TO AND FROM ANY CURRENCY TYPE
static double GetRate(string currency){
    switch (currency)
    {
        case "usd":
            return USD_CURRENCY;
            break;
        case "japanese yen":
            return YEN_CURRENCY;
            break;
        case "chinese yuan":
            return YUAN_CURRENCY;
            break;
        case "british pound":
            return POUND_CURRENCY;
            break;
        case "doubloons":
            return DOUBLOON_CURRENCY;
            break;
        case "algerian dinar":
            return DINAR_CURRENCY;
            break;
        default:
            return double.Parse("INVALID INPUT, TRY AGAIN!");
            break;
    }
}
System.Console.WriteLine("GOODBYE!");
}
// END OF CURRENCY CONVERSION CODE


// Shipping Invoice Prices/Fees
const double TON_PRICE = 220.40;
const double PERISHABLE_TON_PRICE = 230;
const double EXPRESS_FEE = .25;

// Beginning of Shipping Invoice Menu
    if ( numChoice == "2")
{
        System.Console.WriteLine("How many tons of nonperishable parcels are there?");
        double ParcelTons = double.Parse(Console.ReadLine());
        Console.WriteLine();
        System.Console.WriteLine("How many tons of perishable parcels are there?");
        double PerishableParcelTons = double.Parse(Console.ReadLine());
        Console.WriteLine();

        System.Console.WriteLine("Is it an Express Package? \n 1 for Yes \n 2 for No");
                    string ExpressChoice = Console.ReadLine();
            if (ExpressChoice == "1")
            { // Start of Express Parcel
                double ParcelExpressCost = (TON_PRICE * ParcelTons);
                double PerishableParcelExpressCost = (PERISHABLE_TON_PRICE * PerishableParcelTons);
                double TotalParcelExpressCost = (((ParcelTons * TON_PRICE) * .25)  + ((PERISHABLE_TON_PRICE * PerishableParcelTons) * .25) + (ParcelTons * TON_PRICE) + (PERISHABLE_TON_PRICE * PerishableParcelTons));
                Console.WriteLine();
                Console.WriteLine("Your Express Cost is " + TotalParcelExpressCost);
                Console.WriteLine();
                Console.WriteLine("Input your total payment!");
                Console.WriteLine();
                double payment = double.Parse(Console.ReadLine());

                if (payment < TotalParcelExpressCost){
                     Console.WriteLine();
                    Console.WriteLine("ERROR! Insufficienct Funds to complete purchase!!!");
                     Console.WriteLine();
                }
                double change = (payment - TotalParcelExpressCost);
                if (payment >= TotalParcelExpressCost){
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your payment! Here is your change: " + change);
                    Console.WriteLine();
                }// End of Express Parcel Code
            } //Regular Parcel Code
            if ( ExpressChoice == "2")
            {
                double TotalParcelCost = (TON_PRICE * ParcelTons);
                double TotalPerishableParcelCost = (PERISHABLE_TON_PRICE * PerishableParcelTons);
                double TotalShippingCost = (TotalParcelCost + TotalPerishableParcelCost);
                 Console.WriteLine();
                Console.WriteLine("Your Total Cost is " + TotalShippingCost);
                 Console.WriteLine();
                Console.WriteLine("Input your total payment!");
                 Console.WriteLine();

                double payment = double.Parse(Console.ReadLine());

                if (payment < TotalShippingCost){
                     Console.WriteLine();
                    Console.WriteLine("ERROR! Insufficienct Funds to complete purchase!!!");
                     Console.WriteLine();
                }
                double change = (payment - TotalShippingCost);
                if (payment >= TotalShippingCost)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your payment! Here is your change: " + change);
                    Console.WriteLine();
                }
            } //End of Regular Parcel Code
}
    // End of Shipping Invoice Code

    else if ( numChoice == "3"){ // End Menu Choice
        //Done
    }

    else if ( numChoice != "1" && numChoice != "2" && numChoice != "3"){ // Menu Error Handling
        Console.WriteLine();
        System.Console.WriteLine("INVALID CHOICE! TRY AGAIN!");
        Console.WriteLine();
    }

}

System.Console.WriteLine("GOODBYE!");
