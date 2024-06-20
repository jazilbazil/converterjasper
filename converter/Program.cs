Console.WriteLine("Welcome to jaspers shitty converter");

bool keepgoing = true;
while (keepgoing == true) {
    Console.WriteLine("what type of measurement would you like to convert?");
    Console.WriteLine("1. Length");
    Console.WriteLine("2. Capacity");
    Console.WriteLine("3. Mass");
    string input = Console.ReadLine().ToUpper();

    switch (input)
    {

        case "MASS":
            Console.WriteLine("you have selected Mass");
            Console.WriteLine("what system is the initial measurement?");
            Console.WriteLine("Imperial");
            Console.WriteLine("Metric");
            string massinput = Console.ReadLine().ToUpper();
            switch (massinput)
            {
                case "Imperial":
                    Console.WriteLine("what is the initial measurement");
                    Console.WriteLine("1. Ounce");
                    Console.WriteLine("2. Pound");
                    Console.WriteLine("3. Stone");
                    Console.WriteLine("4. Ton");
                    string massinput2 = Console.ReadLine().ToUpper();
                    ""
                    switch (massinput2)
                    {
                        case "ounce";

                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            break;

        default:
            Console.WriteLine("i dont understand");
            Console.WriteLine("would you like to enter something else?");
            string yayornay = Console.ReadLine().ToUpper();
            if (yayornay == "NO" || yayornay == "FALSE")
            {
                keepgoing = false;
            }
            break;

    }
}