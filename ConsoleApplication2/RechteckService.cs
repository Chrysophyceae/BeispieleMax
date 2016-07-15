namespace ConsoleApplication2
{
    public class RechteckService
    {
        public double BerechneFlaeche(RechteckModel objektVonRechteck)
        {
            return objektVonRechteck.getLength() * objektVonRechteck.getWidth();
        }
    }
}
