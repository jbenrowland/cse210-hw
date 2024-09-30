class Program
{

    static void Main (string[] args)
    {
        //Console.WriteLine($"Howdy World");
        Costume nurse = new Costume ();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrile";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope"; 

        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trecnhcoat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass"; 

        nurse.ShowWardrobe();
        detective.ShowWardrobe();    
    }
}