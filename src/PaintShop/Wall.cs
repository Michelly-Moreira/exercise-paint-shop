namespace PaintShop;

// 1 - Crie uma classe Wall
public class Wall
{
    double _width;
    double _height;

// as propriedades Width e Height possuem get implícito e set explícito. Ambas não aceitam valores negativos.
    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
            {
                _width = 1;
            }
            else
            {
                _width = value;
            }
        }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
            {
                _height = 1;
            }
            else
            {
                _height = value;
            }
        }
    }

    // ExcludeArea tem get e set implícitos e retorna a área à ser pintada.
    public double ExcludedArea {get; set;}

    // PaintableArea não tem set e tem get explícito
    public double PaintableArea
    {
        get { return (Width * Height) - ExcludedArea; }
    }
    
    // abaixo tem o construtor para inicializar os atributos Width e Height
    public Wall(double width, double height)
    {
        Width = width;
        Height = height;
    }
}