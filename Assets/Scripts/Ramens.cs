using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AnSeong
{
    private string name = "안성탕면";
    private int id = 0;
    private StringBuilder _stringBuilder = new();

    public Tuple<string, StringBuilder, int> HowToMakeRamen()
    {
        BoilWater();
        AddPowderedSoup();
        AddNoodles();
        PutInBowl();
        Complete();

        Tuple<string, StringBuilder, int> result = new(name, _stringBuilder, id);
        return result;
    }
    
    public void BoilWater()
    {
        _stringBuilder.Append("물을 끓인다.\n");
    }

    public void AddPowderedSoup()
    {
        _stringBuilder.Append("분말 스프를 넣는다.\n");
    }

    public void AddNoodles()
    {
        _stringBuilder.Append("면을 넣는다.\n");
    }

    public void PutInBowl()
    {
        _stringBuilder.Append("그릇에 옮겨 담는다.\n");
    }

    public void Complete()
    {
        _stringBuilder.Append("안성탕면 완성!\n");
    }
}

public class Shin
{
    private string name = "신라면";
    private int id = 1;
    private StringBuilder _stringBuilder = new();

    public Tuple<string, StringBuilder, int> HowToMakeRamen()
    {
        BoilWater();
        AddPowderedSoup();
        AddIngredientsToSoup();
        AddNoodles();
        PutInBowl();
        Complete();

        Tuple<string, StringBuilder, int> result = new(name, _stringBuilder, id);
        return result;
    }
    
    public void BoilWater()
    {
        _stringBuilder.Append("물을 끓인다.\n");
    }

    public void AddPowderedSoup()
    {
        _stringBuilder.Append("분말 스프를 넣는다.\n");
    }

    public void AddIngredientsToSoup()
    {
        _stringBuilder.Append("건더기 스프를 넣는다.\n");
    }

    public void AddNoodles()
    {
        _stringBuilder.Append("면을 넣는다.\n");
    }

    public void PutInBowl()
    {
        _stringBuilder.Append("그릇에 옮겨 담는다.\n");
    }

    public void Complete()
    {
        _stringBuilder.Append("신라면 완성!\n");
    }
}

public class Raccoon
{
    private string name = "너구리";
    private int id = 2;
    private StringBuilder _stringBuilder = new();

    public Tuple<string, StringBuilder, int> HowToMakeRamen()
    {
        BoilWater();
        AddPowderedSoup();
        AddIngredientsToSoup();
        AddKelp();
        AddNoodles();
        PutInBowl();
        Complete();

        Tuple<string, StringBuilder, int> result = new(name, _stringBuilder, id);
        return result;
    }
    
    public void BoilWater()
    {
        _stringBuilder.Append("물을 끓인다.\n");
    }

    public void AddPowderedSoup()
    {
        _stringBuilder.Append("분말 스프를 넣는다.\n");
    }

    public void AddIngredientsToSoup()
    {
        _stringBuilder.Append("건더기 스프를 넣는다.\n");
    }

    public void AddKelp()
    {
        _stringBuilder.Append("다시마를 넣는다.\n");
    }

    public void AddNoodles()
    {
        _stringBuilder.Append("면을 넣는다.\n");
    }

    public void PutInBowl()
    {
        _stringBuilder.Append("그릇에 옮겨 담는다.\n");
    }

    public void Complete()
    {
        _stringBuilder.Append("너구리 완성!\n");
    }
}

public class Seasame
{
    private string name = "참깨라면";
    private int id = 3;
    private StringBuilder _stringBuilder = new();

    public Tuple<string, StringBuilder, int> HowToMakeRamen()
    {
        BoilWater();
        AddPowderedSoup();
        AddIngredientsToSoup();
        AddEggBlock();
        AddNoodles();
        PutInBowl();
        Complete();

        Tuple<string, StringBuilder, int> result = new(name, _stringBuilder, id);
        return result;
    }
    
    public void BoilWater()
    {
        _stringBuilder.Append("물을 끓인다.\n");
    }

    public void AddPowderedSoup()
    {
        _stringBuilder.Append("분말 스프를 넣는다.\n");
    }

    public void AddIngredientsToSoup()
    {
        _stringBuilder.Append("건더기 스프를 넣는다.\n");
    }

    public void AddNoodles()
    {
        _stringBuilder.Append("면을 넣는다.\n");
    }

    public void AddEggBlock()
    {
        _stringBuilder.Append("계란 블럭을 넣는다.\n");
    }

    public void PutInBowl()
    {
        _stringBuilder.Append("그릇에 옮겨 담는다.\n");
    }

    public void Complete()
    {
        _stringBuilder.Append("참깨라면 완성!\n");
    }
}