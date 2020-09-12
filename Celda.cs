public class Celda{
    private int PosicionX;
    private int PosicionY;
    private Pieza Ocupante;

    public Celda(int x,int y,Pieza p){
        this.PosicionX = x;
        this.PosicionY = y;
        this.Ocupante = p;
    }

     public Celda(int x,int y){
        this.PosicionX = x;
        this.PosicionY = y;
    }

     public void SetPosicionX(int posicionX){
        this.PosicionX = posicionX;
    }
     public void SetPosicionY(int posicionY){
        this.PosicionY = posicionY;
    }
     public void SetOcupante(Pieza p){
        this.Ocupante = p;
    }

    public int GetPosicionX(){
        return this.PosicionX;
    }
    public int GetPosicionY(){
        return this.PosicionY;
    }
    public Pieza GetOcupante(){
        return this.Ocupante;
    }

}