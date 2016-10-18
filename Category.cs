using System.Collections.Generic;
public class Category
{
    //protected string[] formations;
    protected List<string> formationsList;
    protected List<Jump> draw;
    protected string name;
    protected Formations formations;
    protected string[] randoms = {"a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "l", "m", "n", "o", "p", "q"};
    protected string[] aBlocks = {"2", "4", "6", "7", "8", "9", "19", "21"};
    protected string[] aaBlocks = {"14", "15", "22"};
    protected string[] aaaBlocks = {"3", "17", "18"};
    protected int minPointPerJump;

    public Category()
    {
        //this.formations = new Formations(this.formationsList, this.minPointPerJump, 0);
    }

    public string getName() {
        return this.name;
    }

    public List<string> getFormations()
    {
        return this.formationsList;
        //return new List<string>(this.formations);
    }
    public List<Jump> getDraw()
    {
        return this.formations.generateJumps();
    }
}

public class Rookie : Category
{
    public Rookie()
    {
        this.name = "Rookie";
        this.minPointPerJump = 3;
        this.formationsList = new List<string>(randoms);
        this.formations = new Formations(this.formationsList, this.minPointPerJump, 0);
        //this.formations = new Formations(this.formations);
    }

}

public class Intermediate : Rookie
{
    public Intermediate()
    {
        this.name = "Intermediate";
        this.minPointPerJump = 3;
        this.formationsList.AddRange(new List<string>(aBlocks));
        this.formations = new Formations(this.formationsList, this.minPointPerJump, 0);
    }
}

public class DoubleA : Intermediate
{
    public DoubleA()
    {
        this.name = "DoubleA";
        this.minPointPerJump = 4;
        this.formationsList.AddRange(new List<string>(aaBlocks));
        this.formations = new Formations(this.formationsList, this.minPointPerJump, 0);
    }
}

public class Open : DoubleA
{
    public Open()
    {
        this.name = "Open";
        this.minPointPerJump = 5;
        this.formationsList.AddRange(new List<string>(aaaBlocks));
        this.formations = new Formations(this.formationsList, this.minPointPerJump, 0);
    }
}