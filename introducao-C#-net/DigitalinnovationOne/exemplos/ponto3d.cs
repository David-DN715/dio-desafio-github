namespace  Classes.herança

{   
    public class Ponto3d : Ponto
    {
        public int z;

        public Ponto3d(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular();
        {
            //faz alguma coisa...
        }

        public override void CalcularDistancia3();
        {
            //Faz alguma coisa...
        }
    }
}
