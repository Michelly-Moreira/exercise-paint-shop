namespace PaintShop;

// 3 - Crie uma classe estática PaintUtilities
public static class PaintUtilities
{
// A propriedade BucketSizeLiters armazena quantos litros de tinta possui um balde.
    public static int BucketSizeLiters { get; set; } = 20;

// A propriedade SquareMetersPerLiter armazena quantos metros quadrados podem ser pintados por litro.
    public static int SquareMetersPerLiter { get; set; } = 10;

// O método SquareMetersPerBucket realiza a conta de quantos metros quadrados podem ser pintados por balde fazendo a multiplicação do m2/litro e de litros por balde.
    public static int SquareMetersPerBucket{
        get { return SquareMetersPerLiter * BucketSizeLiters; }
    }

// O método GetNeededPaintBuckets que realiza a operação da quantidade de baldes necessários fazendo um overload de 03 parâmetros possíveis de entrada: área, parede e quarto (area, wall e room)
    public static int GetNeededPaintBuckets(double area) {
        return Convert.ToInt32(Math.Ceiling(area / SquareMetersPerBucket));
    }

    public static int GetNeededPaintBuckets(Wall wall) {
        return Convert.ToInt32(Math.Ceiling(wall.PaintableArea / SquareMetersPerBucket));
    }

    public static int GetNeededPaintBuckets(Room room) {

        double totalArea = 0;
        foreach(var wall in room.walls)
        {
            totalArea += wall.PaintableArea;
        }
        return Convert.ToInt32(Math.Ceiling(totalArea / SquareMetersPerBucket));
    }

// O método CalculateCost que calcula o preço final fazendo uso do método GetNeededPaintBuckets e também realizando a operação para 03 parâmetros possíveis de entrada: área, parede e quarto (area, wall e room).
    public static decimal CalculateCost(decimal price, double area) {
        return price * GetNeededPaintBuckets(area);
    }

    public static decimal CalculateCost(decimal price, Wall wall) {
        return price * GetNeededPaintBuckets(wall);
    }

    public static decimal CalculateCost(decimal price, Room room) {
        return price * GetNeededPaintBuckets(room);
    }
}