namespace PaintShop;

// 2 - Crie uma classe Room
public class Room
{
    public Wall[] walls { get; }

// O atributo TotalPaintableArea contém a lógica de percorrer o array de Wall e retornar a soma do atributo PaintableArea de todas as paredes.
    public double TotalPaintableArea {
        get {
            double totalArea = 0;
            foreach(var wall in walls)
            {
                totalArea += wall.PaintableArea;
            }
            return totalArea;
        }
    }

    // A lógica do construtor para receber o array de Wall que representa todas as paredes de uma sala Room.
    public Room(params Wall[] walls)
    {
        this.walls = walls;
    }
}
