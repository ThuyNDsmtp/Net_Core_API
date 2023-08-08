public class Fruit
{
    public string Name;
    public string Color;
    public int Quantity { get; set; }
    public Fruit()
    {
        Name = "Nước hoa quả";
        Color = "Màu trắng sữa";
        Quantity = 0;
    }
    public Fruit(string name,string color,int quantity){
        Name = name;
        Color = color;
        Quantity = quantity;
    }
    public void Display(){
        System.Console.WriteLine("Fruit name is {0} with color is {1} and quantity is {2}.",Name,Color,Quantity);
    }
    public int GetQuantity(){
        return Quantity;
    }
}