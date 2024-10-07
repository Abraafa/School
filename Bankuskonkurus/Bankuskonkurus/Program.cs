namespace Bankuskonkurus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till BankusKonkurus©! Du får nu flera val. \r\n Välj '1' för se saldo och information om dina konton. \r\n Välj '2' för Uttag/Insättning/Överföring. \r\n Välj '3' för att avsluta applikationen");
            bool offlinebank = false;
            
            int personKonto = 123456;
            int sparKonto = 654321;
            int investKonto = 112233;
            
            int personSaldo = 133700;
            int sparSaldo = 696969;
            int investSaldo = 50000;


            while (offlinebank == false) 
            {
                int mainchoice = int.MaxValue;
                while (true)
                {
                    try
                    {

                        mainchoice = int.Parse(Console.ReadLine());
                        break;

                    }
                    catch
                    {

                        Console.WriteLine("Vänligen ange en siffra baserat på det val du vill göra!");

                    }
                }

                if (mainchoice == 1) //Kontoinformation
                {

                    Console.WriteLine("Välj '1' för att se ditt Personkonto. \r\n Välj '2' för att se ditt Sparkonto. \r\n Välj '3' för att se ditt Investeringskonto. \r\n Välj '4' för att återgå till huvudmneyn");
                    int saldoKonto = int.Parse(Console.ReadLine());

                    switch (saldoKonto)
                    {

                        case 1:
                            Console.WriteLine("Ditt Personkontos kontonummer är: " + personKonto + " och saldo är: " + personSaldo + "kr");
                            break;

                        case 2:
                            Console.WriteLine("Ditt Sparkontos kontonummer är: " + sparKonto + " och saldo är: " + sparSaldo + "kr");
                            break;

                        case 3:
                            Console.WriteLine("Ditt Investeringskontos kontonummer är: " + investKonto + " och saldo är: " + investSaldo + "kr");
                            break;

                        case 4:
                            Console.WriteLine("Återgår till huvudmenyn!");
                            Console.WriteLine("Välj '1' för se saldo och information om dina konton. \r\n Välj '2' för Uttag/Insättning/Överföring. \r\n Välj '3' för att avsluta applikationen");
                            break;

                        default:
                            Console.WriteLine("Var vänlig välj ett av de alternativ som finns tillgänglig!");
                            Console.WriteLine("Välj '1' för att se ditt Personkonto. \r\n Välj '2' för att se ditt Sparkonto. \r\n Välj '3' för att se ditt Investeringskonto. \r\n Välj '4' för att återgå till huvudmneyn");
                            break;

                    }

                }

                else if (mainchoice == 2) //Handlingar av konton
                {

                    Console.WriteLine("Välj '1' för Uttag. \r\n Välj '2' för Insättning. \r\n Välj '3' för att göra en Överföring \r\n Välj '4' för att återgå till huvudmneyn");
                    int moveMoney = int.Parse(Console.ReadLine());

                    switch (moveMoney)
                    {



                        case 1:
                            Console.WriteLine("Hur mycket vill du ta ut?");
                            int uttag = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ditt nya saldo efter uttag är: " + (personSaldo - uttag) + "kr");
                            personSaldo -= uttag;
                            break;

                        case 2:
                            Console.WriteLine("Hur mycket vill du sätta in?");
                            int pimp = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ditt nya saldo efter uttag är: " + (personSaldo + pimp) + "kr");
                            personSaldo += pimp;
                            break;

                        case 3:
                            int transactionOut;
                            int transactionIn;
                            int transactionSum;
                            Console.WriteLine("Vänligen välj det konto du vill göra överföring från genom att skriva dess kontonummer!");
                            transactionOut = int.Parse(Console.ReadLine());
                            
                            if ( (transactionOut == personKonto) || (transactionOut == sparKonto) || (transactionOut == investKonto) )
                            {
                                Console.WriteLine("Vilket konto vill du överföra till?");
                                transactionIn = int.Parse(Console.ReadLine());
                                
                                if ( (transactionIn == personKonto) || (transactionIn == sparKonto) || (transactionIn == investKonto) ) 
                                {
                                    Console.WriteLine("Slutligen välj den summa du vill föra över till kontonummer: " + transactionIn + "!");
                                    transactionSum = int.Parse(Console.ReadLine());
                                    Console.WriteLine(transactionSum + " har nu förts över från: " + transactionOut + " och har flyttats till: " + transactionIn + "!");
                                    break;

                                }
                                else
                                {
                                    Console.WriteLine("Ingen match. Vänligen välj det konto du vill göra en överföring till genom att skriva dess kontonummer!");
                                    continue;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Ingen match. Vänligen välj det konto du vill göra överföring från genom att skriva dess kontonummer!");
                                continue;
                            }

                        case 4:
                            Console.WriteLine("Återgår till huvudmenyn!");
                            Console.WriteLine("Välj '1' för se saldo och information om dina konton. \r\n Välj '2' för Uttag/Insättning/Överföring. \r\n Välj '3' för att avsluta applikationen");
                            break;

                        default:
                            Console.WriteLine("Var vänlig välj ett av de alternativ som finns tillgänglig!");
                            Console.WriteLine("Välj '1' för Uttag. \r\n Välj '2' för Insättning. \r\n Välj '3' för att göra en Överföring.");
                            break;

                    }
                }

                else if (mainchoice == 3) //Byebye
                {

                    Console.WriteLine("BankusKonkurus© stängs nu ner. Välkommen åter!");
                    offlinebank = true;
                    break;

                }

                else //Hard to press correctly
                {

                    Console.WriteLine("Ogiltlig input, vänligen välj en siffra som är markerad med ''!");
                    continue;

                }
            }
        }
    }
}