class Costume

// attributes (member variable)
public string headWear;

public string gloves;

public string shoes;

public string upperGarment;

public string LowerGarment;

public string accessory;

// behaviors
 void ShowWardrobe();
 {
    string result = "";
    result += $"Head: {headWear}\n";
    result += $"Head: {gloves}\n";
    result += $"Head: {shoes}\n";
    result += $"Head: {upperGarment}\n";
    result += $"Head: {lowerGarment}\n";
    result += $"Head: {accessory}\n";
    Console.WriteLine(result);
 }
}