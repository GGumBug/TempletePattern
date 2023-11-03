using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;

public abstract class RamenTemplete
{
    protected string name;
    protected int id;
    protected StringBuilder stringBuilder = new();
    protected bool addIngredientsToSoup = true;

    public Tuple<string, StringBuilder, int> HowToMakeRamen()
    {
        Hook0();
        BoilWater();
        AddPowderedSoup();
        if (addIngredientsToSoup) { AddIngredientsTOSoup(); }
        Hook2();
        AddNoodles();
        PutInBowl();
        HookComplete();

        Tuple<string, StringBuilder, int> result = new(name, stringBuilder, id);
        return result;
    }

    void BoilWater()
    {
        stringBuilder.Append("물을 끓인다.\n");
    }

    void AddPowderedSoup()
    {
        stringBuilder.Append("분말 스프를 넣는다.\n");
    }

    public void AddIngredientsTOSoup()
    {
        stringBuilder.Append("건더기 스프를 넣는다.\n");
    }

    void AddNoodles()
    {
        stringBuilder.Append("면을 넣는다.\n");
    }

    void PutInBowl()
    {
        stringBuilder.Append("그릇에 옮겨 담는다.\n");
    }

    abstract protected void Hook0();
    abstract protected void Hook2();
    abstract protected void HookComplete();
}

public class TAnseong : RamenTemplete
{
    protected override void Hook0()
    {
        name = "안성탕면";
        id =0;
        addIngredientsToSoup = false;
    }

    protected override void Hook2()
    {
        
    }

    protected override void HookComplete()
    {
        stringBuilder.Append("안성탕면 완성!");
    }
}

public class TShin : RamenTemplete
{
    protected override void Hook0()
    {
        name = "신라면";
        id =1;
    }

    protected override void Hook2()
    {
        
    }

    protected override void HookComplete()
    {
        stringBuilder.Append("신라면 완성!");
    }
}

public class TRaccoon : RamenTemplete
{
    protected override void Hook0()
    {
        name = "너구리";
        id =2;
    }

    protected override void Hook2()
    {
        stringBuilder.Append("다시마를 넣는다.\n");
    }

    protected override void HookComplete()
    {
        stringBuilder.Append("너구리 완성!");
    }
}

public class TSeasame : RamenTemplete
{
    protected override void Hook0()
    {
        name = "참깨라면";
        id =3;
    }

    protected override void Hook2()
    {
        stringBuilder.Append("계란블럭을 넣는다.\n");
    }

    protected override void HookComplete()
    {
        stringBuilder.Append("참깨라면 완성!");
    }
}