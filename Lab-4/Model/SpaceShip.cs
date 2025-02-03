using System;

public class SpaceShip
{
    public int PosicionY {  get;set; }

   public SpaceShip() { 
    
        PosicionY = 0;
    }

    public void MoveUp()
    {
        PosicionY -= 10;

    }

    public void MoveDown() { PosicionY +=10; }
}
