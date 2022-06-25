string[,] dni;
dni = new string[3, 7]; 
dni[0, 0] = "poniedzialek";
dni[0, 1] = "wtorek";
dni[0, 2] = "sroda";
dni[0, 3] = "czwartek";
dni[0, 4] = "piatek";
dni[0, 5] = "sobota";
dni[0, 6] = "niedziela";
dni[1, 0] = "monday";
dni[1, 1] = "tuesday";
dni[1, 2] = "wednesday";
dni[1, 3] = "thursday";
dni[1, 4] = "friday";
dni[1, 5] = "saturday";
dni[1, 6] = "sunday";
dni[2, 0] = "montag";
dni[2, 1] = "dienstag";
dni[2, 2] = "mittwoch";
dni[2, 3] = "donnerstag";
dni[2, 4] = "freitag";
dni[2, 5] = "samstag";
dni[2, 6] = "sonntag";
for (int a = 0; a < 3; a++)
{
    for (int b = 0; b < 7; b++)
    {

        Console.Write("{0,6}" + ", ", dni[a, b]);
    }
    Console.WriteLine();
}

