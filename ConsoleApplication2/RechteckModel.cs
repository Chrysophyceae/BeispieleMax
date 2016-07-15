namespace ConsoleApplication2
{
    public class RechteckModel
    {
        double length;
        double width;

        public RechteckModel(){
        }

        public RechteckModel(double length, double width) {
            this.length = length;
            this.width = width;
        }

        public void setLength(double length){
            this.length = length;
        }

        public double getLength(){
            return length;
        }

        public void setWidth(double width){
            this.width = width;
        }

        public double getWidth(){
            return width;
        }
    }
}