public class Pieza{
    private bool Color;
    private bool Estado;
    private Celda Posicion;

    public Pieza(){
        this.Color = true;
        this.Estado = false;
    }
    public Pieza(bool color, bool estado, Celda c){
        this.Color = color;
        this.Estado = estado;
        this.Posicion = c;
    }

    public void SetColor(bool color){
        this.Color = color;
    }
    public void SetEstado(bool estado){
        this.Estado = estado;
    }
    public void SetPosicion(Celda posicion){
        this.Posicion = posicion;
    }

    public bool GetColor(){
        return this.Color;
    }
    public bool GetEstado(){
        return this.Estado;
    }
    public Celda GetPosicion(){
        return this.Posicion;
    }
}