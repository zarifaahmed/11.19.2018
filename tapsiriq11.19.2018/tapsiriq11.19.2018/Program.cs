using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq11._19._2018
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Card> card_list = new List<Card>();
            card_list.Add(new Card(1, 1224234345, 2135, 322, 1000, "02/12"));
            card_list.Add(new Card(2, 1656734345, 1135, 312, 2000, "02/12"));
            card_list.Add(new Card(3, 1224238775, 3135, 142, 1400, "02/12"));
            card_list.Add(new Card(4, 1226787645, 5135, 782, 2050.25, "02/12"));
            card_list.Add(new Card(5, 1224344334, 6135, 382, 1000, "02/12"));
            card_list.Add(new Card(6, 2325563435, 7135, 479, 100.45, "02/12"));
            card_list.Add(new Card(7, 1124578734, 7435, 909, 19000, "02/12"));
            card_list.Add(new Card(8, 1224234345, 2435, 080, 14000.28, "02/12"));
            card_list.Add(new Card(9, 1354354656, 2445, 398, 1500.15, "02/12"));
            card_list.Add(new Card(10, 4565656554, 1145, 242, 2030, "02/12"));

            List<holder> holder_list = new List<holder>();
            holder_list.Add(new holder(1, "azer", "azerov", 43, card_list[0]));
            holder_list.Add(new holder(2, "ehmed", "ehmedov", 43, card_list[1]));
            holder_list.Add(new holder(3, "memmed", "memmed", 43, card_list[2]));
            holder_list.Add(new holder(4, "yusif", "yusif", 43, card_list[3]));
            holder_list.Add(new holder(5, "xaliq", "xaliq", 43, card_list[4]));
            holder_list.Add(new holder(6, "mehemmed", "mehemmed", 43, card_list[5]));
            holder_list.Add(new holder(7, "ruslan", "ruslan", 43, card_list[6]));
            holder_list.Add(new holder(8, "esger", "esger", 43, card_list[7]));
            holder_list.Add(new holder(9, "mubariz", "mubariz", 43, card_list[8]));
            holder_list.Add(new holder(10, "cesur", "cesur", 43, card_list[9]));


            for (var i = 0; i < 6;)
            {

                Console.WriteLine("Enter card number\n");
                var card_no = long.Parse(Console.ReadLine());
                var card__no = card_list.FirstOrDefault(f => f.cardnumber == card_no);
                if (card__no != null)
                {

                    for (var j = 0; j < 6;)
                    {
                        Console.WriteLine("Enter PIN\n");
                        var card_pin = int.Parse(Console.ReadLine());
                        var card_0 = card_list.FirstOrDefault(f => f.PIN == card_pin);

                        if (card_0 != null)
                        {

                            var parallelperson = holder_list.FirstOrDefault(c => c.kart.PIN == card_pin);
                            if (parallelperson != null)
                            {
                                Console.WriteLine("Name:" + parallelperson.name + " Surname:" + parallelperson.surname + "  Balance:" + parallelperson.kart.balance);

                                for (var l = 0; l < 10;)
                                {
                                    for (var k = 0; k < 10;)
                                    {
                                        var ans = true;
                                        while (ans)
                                        {
                                            Console.WriteLine("Withdraw Cash(enter 1)\n");
                                            Console.WriteLine("Cash-in(enter 2)\n");
                                            var answer1 = Console.ReadLine();

                                            if (answer1 == "1")
                                            {


                                                Console.WriteLine("WITHDRAW CASH (TRANSACTION NO) {0}", 1 + k + l);
                                                Console.WriteLine("Write amount");
                                                var answerofamount = int.Parse(Console.ReadLine());

                                                if (answerofamount > 1000)
                                                {
                                                    Console.WriteLine("Maximum limit of amount excessed");

                                                    k++;

                                                }
                                                else
                                                {
                                                    parallelperson.kart.balance = parallelperson.kart.balance - answerofamount;
                                                    Console.WriteLine("Name:" + parallelperson.name + " Surname:" + parallelperson.surname + "  Balance:" + parallelperson.kart.balance + "  Withdraw amount:" + answerofamount);
                                                    l++;
                                                }


                                            }
                                            if (answer1 == "2")
                                            {
                                                Console.WriteLine("CASH-IN (TRANSACTION NO) {0}", 1 + k + l);
                                                Console.WriteLine("Write amount");
                                                var answerofamount = int.Parse(Console.ReadLine());
                                                if (answerofamount > 1000)
                                                {
                                                    Console.WriteLine("Maximum limit of amount excessed");

                                                    k++;
                                                }
                                                else
                                                {
                                                    parallelperson.kart.balance = parallelperson.kart.balance + answerofamount;
                                                    Console.WriteLine("Name:" + parallelperson.name + " Surname:" + parallelperson.surname + "  Balance:" + parallelperson.kart.balance + "  Cash-in amount:" + answerofamount);
                                                    l++;
                                                }



                                            }
                                            if (1 + k + l > 9)
                                            {
                                                Console.WriteLine("Maximum transaction limit excessed.\nPlease, try after 10 minutes\n");

                                                break;

                                            }
                                            break;
                                        }


                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("PIN is not right\n");
                            j++;
                            i++;
                        };

                    }
                }

                else
                {
                    Console.WriteLine("Wrong card number entered\n");

                    i++;


                }
                if (i == 6)
                {
                    Console.WriteLine("Maximum transaction limit excessed.\nPlease, try after 10 minutes\n");
                    break;
                }
            }
        }


    }











    public class holder
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public Card kart { get; set; }
        public holder(int ID, string Name, string Surname, int Age, Card Kart)
        {
            id = ID;
            name = Name;
            surname = Surname;
            age = Age;
            kart = Kart;
        }

    }

    public class Card
    {

        public int id { get; set; }
        public long cardnumber { get; set; }
        public int PIN { get; set; }
        public int cvs { get; set; }
        public string date;

        public double balance { get; set; }

        public Card(int card_id, long card_number, int card_pin, int card_cvs, double card_balance, string card_date)
        {
            id = card_id;
            cardnumber = card_number;
            PIN = card_pin;
            cvs = card_cvs;
            balance = card_balance;
            date = card_date;
        }


    }
}