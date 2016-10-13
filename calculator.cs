using System;

class SimpleMath
{
    public decimal Add(decimal number1, decimal number2)
    {
        decimal result = number1 + number2;
        return result;
    }
    public decimal Subtract(decimal number1, decimal number2)
    {
        decimal result = number1 - number2;
        return result;
    }
    public decimal Multiply(decimal number1, decimal number2)
    {
        decimal result = number1 * number2;
        return result;
    }
    public decimal Divide(decimal number1, decimal number2)
    {

        decimal result = number1 / number2;
        return result;
    }
    //this function will assign the inputs to variables
    public decimal NumSelect()
    {
        string line = Console.ReadLine();
        return decimal.Parse(line);
    }
    
    public string OperationSelect()
    {
        
      begin:
        
      Console.WriteLine("Would you like to add, subtract, multiply or divide?");
      string operand = Console.ReadLine(); 
      operand = operand.ToLower();
      
      switch (operand)
      {
          case "add":
          case "+":
              return "+";
         case "subtract":
         case "-":
              return "-";
         case "multiply":
         case "*":
              return "*";
         case "divide":
         case "/":
              return "/";
         default: 
              Console.WriteLine("Please type add, subtract multiply or divide");
              goto begin;
      }
    }
    
    public string OperandWord(string operand)
    {
        if (operand == "+")
        {
            return "add";
        }
        else if (operand == "-")
        {
            return "subtract";
        }
        else if (operand == "/")
        {
            return "divide";
        }
        else
        {
            return "multiply";
        }
    }
    
    public decimal Calculate(params string[] paramsArray)
    {
        decimal number1 = decimal.Parse(paramsArray[1]);
        decimal number2 = decimal.Parse(paramsArray[2]);
        
        if (paramsArray[0] == "+")
        {
          decimal result = Add(number1, number2);
          return result;
        } 
        else if (paramsArray[0] == "*")
        {
          decimal result = Multiply(number1, number2);
          return result;
        } 
        else if (paramsArray[0] == "/")
        {
          decimal result = Divide(number1, number2);
          return result;
        } 
        else 
        {
            decimal result = Subtract(number1, number2);
            return result;
        }
    }
    static void Main()
    {
        SimpleMath operation = new SimpleMath();
        
        Console.WriteLine("Welcome to the simple calculator.");
        string operand = operation.OperationSelect();
        string word = operation.OperandWord(operand);
        Console.WriteLine("Give me two numbers and I will {0} them", word);

        decimal number1 = operation.NumSelect();
        decimal number2 = operation.NumSelect();
        
        string num1 = Convert.ToString(number1);
        string num2 = Convert.ToString(number2);
        
        string[] paramsArray = {operand, num1, num2};
        
        decimal result = operation.Calculate(paramsArray);

        // }
       
        Console.WriteLine("{0} {1} {2} = {3}", number1, operand, number2, result);
       
    }
}


