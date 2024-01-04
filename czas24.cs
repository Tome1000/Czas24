public class Czas24h
{
    private int liczbaSekund;

    public int Sekunda
    {
        


        get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
        

        set
        {


            if (value < 0 || value > 59)
            {

                throw new ArgumentException();
            }

            liczbaSekund = value + 60 * Minuta + 3600 * Godzina;


        }
    }

    public int Minuta
    {


        set
        {


            if (value < 0 || value > 59)
            {

                throw new ArgumentException();
            }

            liczbaSekund = Sekunda + 60 * value + 3600 * Godzina;



        }



        get => (liczbaSekund / 60) % 60;
       

       
    }

    public int Godzina
    {



        set {


            if (value < 0 || value > 23)
            {

                throw new ArgumentException();
            }
            else
            {

                liczbaSekund = Sekunda + 60 * Minuta + 3600 * value;



            }
        }

        get => liczbaSekund / 3600;
       
    }

    

    public Czas24h(int godzina, int minuta, int sekunda)
    {
     

        if (godzina < 0 || godzina > 23)
        {

            throw new ArgumentException();
        }
        

        if(minuta < 0 || minuta > 59)
        {

            throw new ArgumentException();
        }


        if (sekunda < 0 || sekunda > 59)
        {

            throw new ArgumentException();
        }

        liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
    }

    public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
}
