interface IToy {
    void setPrice(int price);
    void setColor(string color);
}

interface IMovable {
    void move();
}

interface IFlyable {
    void fly();
}

class ToyHouse : IToy {
    int price;
    string color;
    
    public void setPrice(int price) {
        this.price = price;
    }
    
    public void setColor(string color) {
        this.color=color;
    }
}

class ToyPlane : IToy, IMovable, IFlyable {
    double price;
    string color;

    public void setPrice(int price) {
        this.price = price;
    }

    public void setColor(string color) {
        this.color=color;
    }

    public void move(){//code related to moving plane
    }
    
    public void fly(){// code related to flying plane
    }
}

public class InterfaceSegregation {
    public static void Main(string[] args) {}
}
